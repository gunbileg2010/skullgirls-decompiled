using UdpKit;

namespace Bolt
{
	internal class NetworkProperty_Trigger : NetworkProperty_Mecanim
	{
		public override bool AllowCallbacks => false;

		public override bool WantsOnFrameCloned => false;

		public override bool WantsOnSimulateAfter => false;

		public override object DebugValue(NetworkObj obj, NetworkStorage storage)
		{
			return null;
		}

		public override int BitCount(NetworkObj obj)
		{
			return 0;
		}

		public override void SetDynamic(NetworkObj obj, object value)
		{
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

		public override void OnSimulateAfter(NetworkObj obj)
		{
		}

		public override void OnFrameCloned(NetworkObj obj, NetworkStorage storage)
		{
		}

		private void MecanimPull(NetworkObj obj, NetworkStorage storage)
		{
		}

		private void MecanimPush(NetworkObj obj, bool push)
		{
		}
	}
}
