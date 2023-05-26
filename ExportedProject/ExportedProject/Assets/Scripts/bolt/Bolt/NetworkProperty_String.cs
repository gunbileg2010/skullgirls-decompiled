using UdpKit;

namespace Bolt
{
	internal class NetworkProperty_String : NetworkProperty
	{
		private PropertyStringSettings StringSettings;

		public void AddStringSettings(StringEncodings encoding)
		{
		}

		public override void SetDynamic(NetworkObj obj, object value)
		{
		}

		public override object GetDynamic(NetworkObj obj)
		{
			return null;
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
	}
}
