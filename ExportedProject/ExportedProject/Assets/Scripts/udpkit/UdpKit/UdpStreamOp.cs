namespace UdpKit
{
	internal class UdpStreamOp
	{
		public readonly ulong Key;

		public readonly byte[] Data;

		public readonly UdpChannelName Channel;

		public int BlockCurrent;

		public int BlockSize;

		public int BlockCount;

		public uint CRC;

		public uint DoneTime;

		public ulong Pending;

		public ulong Delivered;

		public bool IsDone => false;

		public int BlocksRemaining => 0;

		public UdpStreamOp(ulong key, UdpChannelName channel, byte[] data)
		{
		}
	}
}
