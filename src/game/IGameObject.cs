namespace Com.Surbon.GDUtils.Game
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
