namespace UdpKit
{
	internal struct UdpPipeConfig
	{
		public const int TYPE_BYTES = 1;

		public const int PING_BYTES = 2;

		public byte PipeId;

		public bool UpdatePing;

		public uint Timeout;

		public int WindowSize;

		public int DatagramSize;

		public int AckBytes;

		public int SequenceBytes;

		public int SequenceBits => 0;

		public int AckBits => 0;

		public int HeaderSize => 0;

		public int HeaderSizeBits => 0;

		public uint NextSequence(uint seq)
		{
			return 0u;
		}

		public int Distance(uint from, uint to)
		{
			return 0;
		}
	}
}
