using System.Collections.Generic;

namespace UdpKit
{
	internal class UdpChannelStreamer
	{
		private ulong SendKeyCounter;

		private ulong RecvKeyCounter;

		private UdpConnection Connection;

		public int Priority;

		public UdpStreamChannel Channel;

		public Dictionary<ulong, UdpStreamOp> OutgoingData;

		public Dictionary<ulong, UdpStreamOp> IncommingData;

		public UdpChannelStreamer(UdpConnection connection, UdpStreamChannel channel)
		{
		}

		public void Queue(byte[] data)
		{
		}

		public void OnBlockLost(UdpStreamOp op, int block)
		{
		}

		public void OnBlockDelivered(UdpStreamOp op, int block)
		{
		}

		public bool TrySend()
		{
			return false;
		}

		public void OnBlockReceived(byte[] buffer, int bytes, int o)
		{
		}

		private void InitOp(UdpStreamOp op, uint crc)
		{
		}

		private bool SendBlock(UdpStreamOp op, int block)
		{
			return false;
		}

		private void RecvBlock(UdpStreamOp op, byte[] buffer, int bytes, int o)
		{
		}
	}
}
