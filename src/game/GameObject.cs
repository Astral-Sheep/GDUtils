﻿using Godot;
using System;

namespace Com.Surbon.GDUtils.Game
{
	public class GameObject : Node, IStateMachine
	{
		protected Action<float> DoAction;

		public override void _Ready()
		{
			base._Ready();

			SetModeVoid();
		}

		public override void _Process(float pDelta)
		{
			base._Process(pDelta);

			DoAction(pDelta);
		}

		public void Start() { SetModeNormal(); }

		void IStateMachine.SetModeVoid() { SetModeVoid(); }
		protected void SetModeVoid() { DoAction = DoActionVoid; }

		void IStateMachine.SetModeNormal() { SetModeNormal(); }
		protected void SetModeNormal() { DoAction = DoActionNormal; }

		void IStateMachine.DoActionVoid(float pDelta) { DoActionVoid(pDelta); }
		protected void DoActionVoid(float pDelta) { }

		void IStateMachine.DoActionNormal(float pDelta) { DoActionNormal(pDelta); }
		protected void DoActionNormal(float pDelta) { }
	}
}
