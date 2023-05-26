using System.Collections.Generic;

namespace Bolt
{
	internal class EventReliableSendBuffer
	{
		private enum State
		{
			Free = 0,
			Send = 1,
			Transit = 2,
			Delivered = 3
		}

		private struct Node
		{
			public State State;

			public EventReliable Value;
		}

		private int tail;

		private int mask;

		private int shift;

		private int count;

		private Node[] nodes;

		private BoltSequenceGenerator generator;

		public IEnumerable<EventReliable> Pending => null;

		public IEnumerable<EventReliable> Delivered => null;

		public bool Full => false;

		public EventReliableSendBuffer(int windowBits, int sequenceBits)
		{
		}

		public bool TryEnqueue(EventReliable value)
		{
			return false;
		}

		public bool TryNext(out EventReliable value)
		{
			value = default(EventReliable);
			return false;
		}

		public void SetDelivered(EventReliable value)
		{
		}

		public void SetSend(EventReliable value)
		{
		}

		public bool TryRemove(out EventReliable value)
		{
			value = default(EventReliable);
			return false;
		}

		private void ChangeState(EventReliable value, State state)
		{
		}

		private int SequenceDistance(uint from, uint to)
		{
			return 0;
		}
	}
}
