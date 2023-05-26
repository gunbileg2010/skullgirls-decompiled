using System.Collections.Generic;
using UdpKit;

namespace Bolt
{
	internal class EventChannel : BoltChannel
	{
		private List<EventUnreliable> unreliableSend;

		private EventReliableSendBuffer reliableOrderedSend;

		private EventReliableRecvBuffer reliableOrderedRecv;

		public void Queue(Event ev)
		{
		}

		public override void Delivered(Packet packet)
		{
		}

		public override void Lost(Packet packet)
		{
		}

		public override void Pack(Packet packet)
		{
		}

		private bool PackEvent(Event ev, UdpPacket stream, uint sequence)
		{
			return false;
		}

		public override void Read(Packet packet)
		{
		}

		private Event ReadEvent(UdpPacket stream, ref uint sequence)
		{
			return null;
		}
	}
}
