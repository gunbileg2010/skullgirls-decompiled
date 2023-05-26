namespace UdpKit
{
	public class NatFeatures
	{
		public UdpEndPoint WanEndPoint;

		public UdpEndPoint LanEndPoint;

		public NatFeatureStates AllowsUnsolicitedTraffic;

		public NatFeatureStates SupportsHairpinTranslation;

		public NatFeatureStates SupportsEndPointPreservation;

		public NatFeatures Clone()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
