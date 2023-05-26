namespace Bolt
{
	internal struct PropertyExtrapolationSettings
	{
		public bool Enabled;

		public int MaxFrames;

		public float ErrorTolerance;

		public float SnapMagnitude;

		public ExtrapolationVelocityModes VelocityMode;

		public static PropertyExtrapolationSettings Create(int maxFrames, float errorTolerance, float snapMagnitude, ExtrapolationVelocityModes velocityMode)
		{
			return default(PropertyExtrapolationSettings);
		}
	}
}
