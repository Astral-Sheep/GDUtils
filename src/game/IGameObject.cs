namespace Com.Surbon.GDUtils.Game
{
	public interface IGameObject
	{
		public void Start();
		public void SetModeVoid();
		public void SetModeNormal();
		public void DoActionVoid(float pDelta);
		public void DoActionNormal(float pDelta);
	}
}
