namespace Bolt
{
	internal struct PropertyTransformCompressionSettings
	{
		public PropertyVectorCompressionSettings Position;

		public PropertyQuaternionCompression Rotation;

		public static PropertyTransformCompressionSettings Create(PropertyVectorCompressionSettings position, PropertyQuaternionCompression rotation)
		{
			return default(PropertyTransformCompressionSettings);
		}
	}
}
