namespace UdpKit
{
	internal class UdpPipe
	{
		private struct SendInfo
		{
			public uint Sequence;

			public UdpRingBuffer<UdpPipeHandle> Window;
		}

		private struct RecvInfo
		{
			public int PendingAcks;

			public UdpRingBuffer<Ack> History;
		}

		private struct Ack
		{
			public readonly uint Time;

			public readonly bool Received;

			public readonly uint Sequence;

			private Ack(uint sequence, bool received, uint time)
			{
			}

			internal static Ack Lost(uint sequence)
			{
				return default(Ack);
			}

			internal static Ack Recv(uint sequence, uint time)
			{
				return default(Ack);
			}
		}

		public const int PIPE_COMMAND = 1;

		public const int PIPE_PACKET = 3;

		public const int PIPE_STREAM = 4;

		public const int PIPE_STREAM_UNRELIABLE = 5;

		public const int PIPE_MASTERSERVER = 2;

		public const int PIPE_UNCONNECTED = 0;

		private SendInfo Send;

		private RecvInfo Recv;

		public UdpPipeConfig Config;

		public UdpConnection Connection;

		public UdpSocket Socket => null;

		public byte Id => 0;

		public float FillRatio => 0f;

		public uint LastSend => 0u;

		public UdpPipe(UdpConnection connection, UdpPipeConfig config)
		{
		}

		public void CheckTimeouts(uint now)
		{
		}

		private void SendAckPacket()
		{
		}

		public void Disconnected()
		{
		}

		public bool WriteHeader(byte[] buffer, object obj)
		{
			return false;
		}

		public bool ReadHeader(byte[] buffer, int size)
		{
			return false;
		}

		private bool ReadAcks(byte[] buffer, int o)
		{
			return false;
		}

		private void Lost(UdpPipeHandle handle)
		{
		}

		private void Delivered(UdpPipeHandle handle)
		{
		}
	}
}
