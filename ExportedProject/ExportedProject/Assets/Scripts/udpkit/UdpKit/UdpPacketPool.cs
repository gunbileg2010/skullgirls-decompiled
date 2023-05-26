using System.Collections.Generic;

namespace UdpKit
{
	public class UdpPacketPool
	{
		private readonly UdpSocket socket;

		private readonly Stack<UdpPacket> pool;

		internal UdpPacketPool(UdpSocket s)
		{
		}

		internal void Release(UdpPacket stream)
		{
		}

		public UdpPacket Acquire()
		{
			return null;
		}

		public void Free()
		{
		}
	}
}
