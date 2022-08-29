using Godot;
using System;

namespace Com.Surbon.GDUtils.Game
{
	public class GameObject : Node, IGameObject
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

		void IGameObject.SetModeVoid() { SetModeVoid(); }
		protected void SetModeVoid() { DoAction = DoActionVoid; }

		void IGameObject.SetModeNormal() { SetModeNormal(); }
		protected void SetModeNormal() { DoAction = DoActionNormal; }

		void IGameObject.DoActionVoid(float pDelta) { DoActionVoid(pDelta); }
		protected void DoActionVoid(float pDelta) { }

		void IGameObject.DoActionNormal(float pDelta) { DoActionNormal(pDelta); }
		protected void DoActionNormal(float pDelta) { }
	}
}
