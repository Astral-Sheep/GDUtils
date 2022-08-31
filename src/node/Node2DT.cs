using Com.Surbon.GDUtils.Math;
using Com.Surbon.GDUtils.StateMachines;
using Godot;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Surbon.GDUtils.Node
{
	public static class Node2DT
	{
		public class Mobile2D : GameObject2D
		{
			// Movement fields
			[Export] protected bool instantAcceleration = false;
			[Export] protected float speed = 500;
			[Export] protected float acceleration = 100;
			protected Vector2 velocity = Vector2.Zero;
			protected Vector2 accelerationVec = Vector2.Zero;

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
					velocity = VectorT.ClampLength(velocity, 0, speed);
				}
			}
		}

		public class KinematicPlayer2D : Mobile2D
		{
			// Body fields
			[Export] protected NodePath bodyPath;
			protected KinematicBody2D body;
			protected KinematicCollision2D collision;

			public override void _Ready()
			{
				base._Ready();

				body = GetNode<KinematicBody2D>(bodyPath);
			}

			/// <summary>
			/// Equivalent to the KinematicBody2D method <see cref="KinematicBody2D.MoveAndCollide"/>.
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
			/// Equivalent to the KinematicBody2D method <see cref="KinematicBody2D.MoveAndSlide"/> (Only works on vertical and horizontal surfaces by now).
			/// </summary>
			/// <param name="pDirection">The vector corresponding to the direction of the movement (clamped between 0 and 1).</param>
			/// <param name="pDelta">The delta time in seconds.</param>
			public virtual void MoveAndSlide(Vector2 pDirection, float pDelta)
			{
				ComputeVelocity(pDirection, pDelta);

				Vector2 lBodyBeginPos = body.GlobalPosition;
				Vector2 lDistance;

				collision = body.MoveAndCollide(velocity * pDelta);

				if (collision?.Collider is Node2D)
				{
					if (collision.Remainder.x != 0 || collision.Remainder.y != 0)
					{
						if (collision.Remainder.x == 0 || collision.Remainder.y == 0)
						{
							if (collision.Normal.x != 0 && collision.Normal.y != 0)
							{
								Vector2 lRemainder = collision.Remainder.Dot(collision.Normal.Rotated(Mathf.Pi / 2f)) > 0 ?
								collision.Normal.Rotated(Mathf.Pi / 2f) :
								collision.Normal.Rotated(-Mathf.Pi / 2f);
								lRemainder = VectorT.Normalize(lRemainder, collision.Remainder.Length());
								body.Position += collision.Normal * 0.01f; // Avoid colliding in the next line
								body.MoveAndCollide(lRemainder);
							}
						}
						else if (collision.Normal.x / collision.Remainder.x != collision.Normal.y / collision.Remainder.y)
						{
							Vector2 lRemainder = collision.Remainder.Dot(collision.Normal.Rotated(Mathf.Pi / 2f)) > 0 ?
								collision.Normal.Rotated(Mathf.Pi / 2f) :
								collision.Normal.Rotated(-Mathf.Pi / 2f);
							lRemainder = VectorT.Normalize(lRemainder, collision.Remainder.Length());
							body.Position += collision.Normal * 0.01f; // Avoid colliding in the next line
							body.MoveAndCollide(lRemainder);
						}
					}
				}

				lDistance = body.GlobalPosition - lBodyBeginPos;

				GlobalPosition += lDistance;
				body.Position -= lDistance;
			}
		}

		public class AreaPlayer2D : Mobile2D
		{
			// Body fields
			[Export] protected NodePath bodyPath;
			protected Area2D body;

			public override void _Ready()
			{
				base._Ready();

				body = GetNode<Area2D>(bodyPath);
			}
		}
	}
}
