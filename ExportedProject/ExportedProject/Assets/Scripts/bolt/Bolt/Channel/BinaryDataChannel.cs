using System.Collections.Generic;

namespace Bolt.Channel
{
	internal class BinaryDataChannel : BoltChannel
	{
		public Queue<byte[]> Incomming;

		public Queue<byte[]> Outgoing;

		public override void Pack(Packet packet)
		{
		}

		public override void Read(Packet packet)
		{
		}

		public override void Disconnected()
		{
		}
	}
}
