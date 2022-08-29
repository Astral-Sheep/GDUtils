﻿namespace Com.Surbon.GDUtils.StateMachines
{
	public interface IStateMachine
	{
		public void Start();
		public void SetModeVoid();
		public void SetModeNormal();
		public void DoActionVoid(float pDelta);
		public void DoActionNormal(float pDelta);
	}
}
