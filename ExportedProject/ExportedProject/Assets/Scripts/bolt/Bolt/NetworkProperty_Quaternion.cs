using UdpKit;

namespace Bolt
{
	internal class NetworkProperty_Quaternion : NetworkProperty
	{
		private PropertyQuaternionCompression Compression;

		public override bool WantsOnSimulateBefore => false;

		public void Settings_Quaternion(PropertyFloatCompressionSettings compression, bool strict)
		{
		}

		public void Settings_QuaternionEuler(PropertyFloatCompressionSettings x, PropertyFloatCompressionSettings y, PropertyFloatCompressionSettings z, bool strict)
		{
		}

		public override void SetDynamic(NetworkObj obj, object value)
		{
		}

		public override object GetDynamic(NetworkObj obj)
		{
			return null;
		}

		public override void OnInit(NetworkObj obj)
		{
		}

		public override object DebugValue(NetworkObj obj, NetworkStorage storage)
		{
			return null;
		}

		public override int BitCount(NetworkObj obj)
		{
			return 0;
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

		public override void OnSimulateBefore(NetworkObj obj)
		{
		}

		public override void SmoothCommandCorrection(NetworkObj obj, NetworkStorage from, NetworkStorage to, NetworkStorage storage, float t)
		{
		}
	}
}
