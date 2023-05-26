using System;
using System.Collections.Generic;
using UdpKit;

namespace Bolt
{
	internal class Packet : IDisposable
	{
		public bool Pooled;

		public int Frame;

		public int Number;

		public PacketStats Stats;

		public UdpPacket UdpPacket;

		public List<EventReliable> ReliableEvents;

		public Queue<EntityProxyEnvelope> EntityUpdates;

		public void Dispose()
		{
		}
	}
}
