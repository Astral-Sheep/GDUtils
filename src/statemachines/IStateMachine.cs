namespace Com.Surbon.GDUtils.StateMachines
{
	/// <summary>
	/// Interface corresponding to a basic state machine.
	/// </summary>
	public interface IStateMachine
	{
		/// <summary>
		/// Start the instance (by default it's supposed to be equivalent to SetModeNormal).
		/// </summary>
		public void Start();
		/// <summary>
		/// Set DoAction to DoActionVoid.
		/// </summary>
		public void SetModeVoid();
		/// <summary>
		/// Set DoAction to DoActionNormal.
		/// </summary>
		public void SetModeNormal();
		/// <summary>
		/// Do nothing (by default).
		/// </summary>
		/// <param name="pDelta">The delta time in seconds.</param>
		public void DoActionVoid(float pDelta);
		/// <summary>
		/// Do the default action.
		/// </summary>
		/// <param name="pDelta">The delta time in seconds.</param>
		public void DoActionNormal(float pDelta);
	}
}
