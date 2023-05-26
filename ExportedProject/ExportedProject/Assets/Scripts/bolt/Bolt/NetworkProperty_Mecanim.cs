namespace Bolt
{
	internal abstract class NetworkProperty_Mecanim : NetworkProperty
	{
		public MecanimMode MecanimMode;

		public MecanimDirection MecanimDirection;

		public float MecanimDamping;

		public int MecanimLayer;

		public override bool WantsOnSimulateAfter => false;

		public void Settings_Mecanim(MecanimMode mode, MecanimDirection direction, float damping, int layer)
		{
		}

		public override void OnSimulateAfter(NetworkObj obj)
		{
		}

		protected bool ShouldPullDataFromMecanim(NetworkState state)
		{
			return false;
		}

		protected virtual void PullMecanimValue(NetworkState state)
		{
		}

		protected virtual void PushMecanimValue(NetworkState state)
		{
		}

		private void PullMecanimLayer(NetworkState state)
		{
		}

		private void PushMecanimLayer(NetworkState state)
		{
		}
	}
}
