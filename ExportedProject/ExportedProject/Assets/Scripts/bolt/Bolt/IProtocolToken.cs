using UdpKit;

namespace Bolt
{
	public interface IProtocolToken
	{
		void Read(UdpPacket packet);

		void Write(UdpPacket packet);
	}
}
