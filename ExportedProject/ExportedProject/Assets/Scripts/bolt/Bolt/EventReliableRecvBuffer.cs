namespace Bolt
{
	internal class EventReliableRecvBuffer
	{
		private struct Node
		{
			public bool Received;

			public EventReliable Value;
		}

		private int tail;

		private int mask;

		private int sequenceShift;

		private uint sequenceNext;

		private uint sequenceMask;

		private readonly Node[] nodes;

		public EventReliableRecvBuffer(int windowBits, int sequenceBits)
		{
		}

		public bool TryRemove(out EventReliable value)
		{
			value = default(EventReliable);
			return false;
		}

		public RecvBufferAddResult TryEnqueue(EventReliable value)
		{
			return default(RecvBufferAddResult);
		}
	}
}
