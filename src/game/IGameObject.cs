using Godot;
using System;

namespace Com.Surbon.GDUtils
{
	public interface IGameObject
	{
		public void Start();
		protected void SetModeVoid();
		protected void SetModeNormal();
		protected void DoActionVoid(float pDelta);
		protected void DoActionNormal(float pDelta);
	}
}
