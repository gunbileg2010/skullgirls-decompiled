using System.Collections.Generic;

namespace Bolt
{
	internal class PacketPool
	{
		private static readonly Stack<Packet> Pool;

		public static Packet Acquire()
		{
			return null;
		}

		public static void ReturnToPool(Packet packet)
		{
		}
	}
}
