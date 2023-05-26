using System;

namespace UdpKit.Protocol
{
	internal abstract class Message
	{
		public const byte MESSAGE_HEADER = byte.MaxValue;

		private int _ptr;

		private byte[] _buffer;

		private byte _type;

		private bool _pack;

		public Guid GameId;

		public Guid PeerId;

		public Guid MessageId;

		public UdpEndPoint Sender;

		public UdpEndPoint Target;

		public uint SendTime;

		public uint Timeout;

		public uint Attempts;

		public Context Context;

		public bool Read => false;

		public bool Pack => false;

		public Message()
		{
		}

		public void Init(byte type)
		{
		}

		public void InitBuffer(int ptr, byte[] buffer, bool pack)
		{
		}

		public int Serialize(int ptr, byte[] buffer, bool pack)
		{
			return 0;
		}

		public int Serialize()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		protected void Create<T>(ref T value) where T : class, new()
		{
		}

		protected void Serialize<T>(ref T value) where T : struct
		{
		}

		protected void Serialize(ref UdpSession session)
		{
		}

		protected void Serialize(ref NatFeatures features)
		{
		}

		protected void Serialize(ref bool value)
		{
		}

		protected void Serialize(ref byte value)
		{
		}

		protected void Serialize(ref int value)
		{
		}

		protected void Serialize(ref uint value)
		{
		}

		protected void Serialize(ref string value)
		{
		}

		protected void Serialize(ref byte[] value)
		{
		}

		protected void Serialize(ref Guid value)
		{
		}

		protected void Serialize(ref UdpEndPoint value)
		{
		}

		protected virtual void OnSerialize()
		{
		}

		private bool HasSpace(int bytes)
		{
			return false;
		}

		private static int EnumToInt<T>(T value) where T : struct
		{
			return 0;
		}

		private static T IntToEnum<T>(int value) where T : struct
		{
			return default(T);
		}
	}
}
