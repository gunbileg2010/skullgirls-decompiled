using System;

namespace UdpKit.Protocol
{
	internal class Context
	{
		private readonly Guid peerId;

		private readonly Guid gameId;

		private static readonly Type[] messageTypes;

		public Guid PeerId => default(Guid);

		public Guid GameId => default(Guid);

		public Context(Guid game)
		{
		}

		public Context(Guid game, Guid peer)
		{
		}

		static Context()
		{
		}

		public T CreateMessage<T>() where T : Message
		{
			return null;
		}

		public T CreateMessage<T>(Query query) where T : Result
		{
			return null;
		}

		public Message CreateMessage(byte type)
		{
			return null;
		}

		public int WriteMessage(Message msg, byte[] buffer)
		{
			return 0;
		}

		public Message ParseMessage(byte[] bytes)
		{
			return null;
		}

		public Message ParseMessage(byte[] bytes, ref int offset)
		{
			return null;
		}

		public static void RegisterMessageType<T>() where T : Message
		{
		}
	}
}
