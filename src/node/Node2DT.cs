using Com.Surbon.GDUtils.Math;
using Com.Surbon.GDUtils.StateMachines;
using Godot;

namespace Com.Surbon.GDUtils.Node
{
	public static class Node2DT
	{
		/// <summary>
		/// Mobile 2D object (useful description isn't it).
		/// </summary>
		public class Mobile2D : GameObject2D
		{
			// Movement fields
			[Export] protected bool useFriction = true;
			[Export] protected bool instantAcceleration = false;
			[Export] protected float speed = 500;
			[Export] protected float acceleration = 100;
			[Export] protected float friction = 0.5f;
			protected Vector2 velocity = Vector2.Zero;
			protected Vector2 accelerationVec = Vector2.Zero;

			/// <summary>
			/// Moves the instance in the given direction.
			/// </summary>
			/// <param name="pDirection">The direction of the movement clamped between 0 and 1.</param>
			/// <param name="pDelta">The delta time in seconds.</param>
			public virtual void Move(Vector2 pDirection, float pDelta)
			{
				ComputeVelocity(pDirection, pDelta);

				Position += velocity * pDelta;
			}

			protected virtual void ComputeVelocity(Vector2 pDirection, float pDelta)
			{
				pDirection = VectorT.ClampLength(pDirection, 0, 1);

				if (instantAcceleration)
				{
					velocity = pDirection * speed;
				}
				else
				{
					accelerationVec = pDirection * acceleration;
					velocity += accelerationVec * pDelta;
					if (useFriction) { velocity = VectorT.Pow(velocity, friction); }

					velocity = VectorT.ClampLength(velocity, 0, speed);
				}
			}
		}

		/// <summary>
		/// Mobile object with a child <see cref="KinematicBody2D"/> to collide. Use method <see cref="GetBody"/> to access it.
		/// </summary>
		public class KinematicMobile2D : Mobile2D
		{
			// Body fields
			[Export] protected NodePath bodyPath;
			protected KinematicBody2D body;

			public override void _Ready()
			{
				base._Ready();

				body = GetNode<KinematicBody2D>(bodyPath);
			}

			/// <summary>
			/// Returns the <see cref="KinematicBody2D"/> used for collisions.
			/// </summary>
			public virtual KinematicBody2D GetBody() => body;

			/// <summary>
			/// Equivalent to the <see cref="KinematicBody2D"/> method <see cref="KinematicBody2D.MoveAndCollide"/> but for <see cref="KinematicMobile2D"/>.
			/// </summary>
			/// <param name="pDirection">The vector corresponding to the direction of the movement (clamped between 0 and 1).</param>
			/// <param name="pDelta">The delta time in seconds.</param>
			public virtual void MoveAndCollide(Vector2 pDirection, float pDelta)
			{
				ComputeVelocity(pDirection, pDelta);

				Vector2 lBodyBeginPos = body.GlobalPosition;
				Vector2 lBodyEndPos;
				Vector2 lDistance;

				body.MoveAndCollide(velocity * pDelta);
				lBodyEndPos = body.GlobalPosition;
				lDistance = lBodyEndPos - lBodyBeginPos;

				GlobalPosition += lDistance;
				body.Position -= lDistance;
			}

			/// <summary>
			/// Equivalent to the <see cref="KinematicBody2D"/> method <see cref="KinematicBody2D.MoveAndSlide"/> but for <see cref="KinematicMobile2D"/>.
			/// </summary>
			/// <param name="pDirection">The vector corresponding to the direction of the movement (clamped between 0 and 1).</param>
			/// <param name="pDelta">The delta time in seconds.</param>
			public virtual void MoveAndSlide(Vector2 pDirection, float pDelta)
			{
				ComputeVelocity(pDirection, pDelta);

				Vector2 lBodyBeginPos = body.GlobalPosition;
				Vector2 lDistance;

				KinematicCollision2D lCollision = body.MoveAndCollide(velocity * pDelta);

				if (lCollision?.Collider is Node2D)
				{
					if (lCollision.Remainder.x != 0 || lCollision.Remainder.y != 0)
					{
						if (lCollision.Remainder.x == 0 || lCollision.Remainder.y == 0)
						{
							if (lCollision.Normal.x != 0 && lCollision.Normal.y != 0)
							{
								Vector2 lRemainder = lCollision.Remainder.Dot(lCollision.Normal.Rotated(Mathf.Pi / 2f)) > 0 ?
								lCollision.Normal.Rotated(Mathf.Pi / 2f) :
								lCollision.Normal.Rotated(-Mathf.Pi / 2f);
								lRemainder = VectorT.Normalize(lRemainder, lCollision.Remainder.Length());
								body.Position += lCollision.Normal * 0.01f; // Avoid colliding in the next line
								body.MoveAndCollide(lRemainder);
							}
						}
						else if (lCollision.Normal.x / lCollision.Remainder.x != lCollision.Normal.y / lCollision.Remainder.y)
						{
							Vector2 lRemainder = lCollision.Remainder.Dot(lCollision.Normal.Rotated(Mathf.Pi / 2f)) > 0 ?
								lCollision.Normal.Rotated(Mathf.Pi / 2f) :
								lCollision.Normal.Rotated(-Mathf.Pi / 2f);
							lRemainder = VectorT.Normalize(lRemainder, lCollision.Remainder.Length());
							body.Position += lCollision.Normal * 0.01f; // Avoid colliding in the next line
							body.MoveAndCollide(lRemainder);
						}
					}
				}

				lDistance = body.GlobalPosition - lBodyBeginPos;

				GlobalPosition += lDistance;
				body.Position -= lDistance;
			}
		}

		/// <summary>
		/// Mobile object with a child <see cref="Area2D"/> to collide. Use method <see cref="GetBody"/> to access it.
		/// </summary>
		public class AreaMobile2D : Mobile2D
		{
			// Body fields
			[Export] protected NodePath bodyPath;
			protected Area2D body;

			public override void _Ready()
			{
				base._Ready();

				body = GetNode<Area2D>(bodyPath);
			}

			/// <summary>
			/// Returns the Area2D used for collisions.
			/// </summary>
			public virtual Area2D GetBody() => body;
		}
	}
}
