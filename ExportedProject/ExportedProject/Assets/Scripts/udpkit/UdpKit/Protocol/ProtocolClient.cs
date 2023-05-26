using System;
using System.Collections.Generic;

namespace UdpKit.Protocol
{
	internal class ProtocolClient : UdpKit.Protocol.Context
	{
		private struct AckCallback
		{
			public UdpEndPoint Filter;

			public Action<UdpKit.Protocol.Query> Action;
		}

		private struct MsgHandler
		{
			public UdpEndPoint Filter;

			public Action<UdpKit.Protocol.Message> Action;
		}

		public uint LastSend;

		public byte[] Buffer;

		public UdpPlatformSocket Socket;

		private List<UdpKit.Protocol.Query> Queries;

		private Dictionary<Type, MsgHandler> Handlers;

		private Dictionary<Type, AckCallback> Callbacks;

		public UdpPlatform Platform => null;

		public ProtocolClient(UdpPlatformSocket socket, Guid gameId, Guid peerId)
			: base(default(Guid))
		{
		}

		public void SetHandler<T>(Action<T> handler) where T : UdpKit.Protocol.Message
		{
		}

		public void SetHandler<T>(Action<T> handler, UdpEndPoint filter) where T : UdpKit.Protocol.Message
		{
		}

		public void SetCallback<T>(Action<T> callback) where T : UdpKit.Protocol.Query
		{
		}

		public void SetCallback<T>(Action<T> callback, UdpEndPoint filter) where T : UdpKit.Protocol.Query
		{
		}

		public void Update(uint now)
		{
		}

		private void RemoveQueryAt(ref int i)
		{
		}

		private bool GetValidCallback(UdpKit.Protocol.Query qry, out AckCallback callback)
		{
			callback = default(AckCallback);
			return false;
		}

		private bool GetValidHandler(UdpKit.Protocol.Message msg, out MsgHandler handler)
		{
			handler = default(MsgHandler);
			return false;
		}

		public void Recv(UdpEndPoint endpoint, byte[] buffer, int offset)
		{
		}

		public void Send(UdpKit.Protocol.Message msg, UdpEndPoint endpoint)
		{
		}

		private void QueryResult(UdpKit.Protocol.Result result)
		{
		}

		private void QueryFilter(Type t, UdpEndPoint endpoint)
		{
		}
	}
}
