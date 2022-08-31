﻿using Com.Surbon.GDUtils.Math;
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
				}
			}
		}

		public class KinematicPlayer2D : Mobile2D
		{
			// Body fields
			[Export] protected NodePath bodyPath;
			protected KinematicBody2D body;

			public override void _Ready()
			{
				base._Ready();

				body = GetNode<KinematicBody2D>(bodyPath);
			}

			public void MoveAndCollide(Vector2 pDirection, float pDelta)
			{
				ComputeVelocity(pDirection, pDelta);

				Vector2 lBodyBeginPos = body.GlobalPosition;
				Vector2 lBodyEndPos;

				body.MoveAndCollide(velocity);
				lBodyEndPos = body.GlobalPosition;

				body.GlobalPosition = lBodyBeginPos;
				Position += lBodyEndPos - lBodyBeginPos;
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
