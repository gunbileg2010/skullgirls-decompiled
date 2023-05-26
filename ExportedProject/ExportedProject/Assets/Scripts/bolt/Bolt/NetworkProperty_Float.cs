using UdpKit;

namespace Bolt
{
	internal class NetworkProperty_Float : NetworkProperty_Mecanim
	{
		private PropertyFloatSettings Settings;

		private PropertyFloatCompressionSettings Compression;

		public override bool WantsOnSimulateBefore => false;

		public override void OnSimulateBefore(NetworkObj obj)
		{
		}

		public override void SetDynamic(NetworkObj obj, object value)
		{
		}

		public override object GetDynamic(NetworkObj obj)
		{
			return null;
		}

		public void Settings_Float(PropertyFloatCompressionSettings compression)
		{
		}

		public void Settings_Float(PropertyFloatSettings settings)
		{
		}

		public override int BitCount(NetworkObj obj)
		{
			return 0;
		}

		public override object DebugValue(NetworkObj obj, NetworkStorage storage)
		{
			return null;
		}

		public override bool Write(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
			return false;
		}

		public override void Read(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
		}

		public override void Read(BoltConnection connection, NetworkObj obj, NetworkStorage storage, NetworkStorage other)
		{
		}

		public override bool Equals(NetworkObj obj, NetworkStorage storage1, NetworkStorage storage2)
		{
			return false;
		}

		public override bool SupportsDeltaCompression()
		{
			return false;
		}

		protected override void PullMecanimValue(NetworkState state)
		{
		}

		protected override void PushMecanimValue(NetworkState state)
		{
		}

		public override void SmoothCommandCorrection(NetworkObj obj, NetworkStorage from, NetworkStorage to, NetworkStorage storage, float t)
		{
		}
	}
}
