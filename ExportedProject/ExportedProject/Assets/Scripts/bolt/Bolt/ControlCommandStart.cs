using UdpKit;

namespace Bolt
{
	internal class ControlCommandStart : ControlCommand
	{
		public BoltConfig Config;

		public BoltNetworkModes Mode;

		public UdpPlatform Platform;

		public UdpEndPoint EndPoint;

		public override void Run()
		{
		}

		public override void Done()
		{
		}
	}
}
