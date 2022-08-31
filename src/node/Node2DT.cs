using Com.Surbon.GDUtils.StateMachines;
using Godot;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Surbon.GDUtils.Node
{
	public static class Node2DT
	{
		public class AreaPlayer2D : GameObject2D
		{
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
