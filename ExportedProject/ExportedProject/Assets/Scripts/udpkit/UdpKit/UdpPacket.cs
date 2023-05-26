using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace UdpKit
{
	public class UdpPacket : IDisposable
	{
		internal bool IsPooled;

		internal UdpPacketPool Pool;

		public bool Write;

		public int Ptr;

		public int Length;

		public byte[] Data;

		public object UserToken
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int Size
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Position
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool Done => false;

		public bool Overflowing => false;

		public byte[] ByteBuffer => null;

		public UdpPacket()
		{
		}

		public UdpPacket(byte[] arr)
		{
		}

		public UdpPacket(byte[] arr, int size)
		{
		}

		public bool CanWrite()
		{
			return false;
		}

		public bool CanRead()
		{
			return false;
		}

		public bool CanWrite(int bits)
		{
			return false;
		}

		public bool CanRead(int bits)
		{
			return false;
		}

		public byte[] DuplicateData()
		{
			return null;
		}

		public bool WriteBool(bool value)
		{
			return false;
		}

		public bool ReadBool()
		{
			return false;
		}

		public void WriteByte(byte value, int bits)
		{
		}

		public byte ReadByte(int bits)
		{
			return 0;
		}

		public void WriteByte(byte value)
		{
		}

		public byte ReadByte()
		{
			return 0;
		}

		public void WriteUShort(ushort value, int bits)
		{
		}

		public ushort ReadUShort(int bits)
		{
			return 0;
		}

		public void WriteUShort(ushort value)
		{
		}

		public ushort ReadUShort()
		{
			return 0;
		}

		public void WriteShort(short value, int bits)
		{
		}

		public short ReadShort(int bits)
		{
			return 0;
		}

		public void WriteShort(short value)
		{
		}

		public short ReadShort()
		{
			return 0;
		}

		public void Serialize(ref uint value, int bits)
		{
		}

		public void Serialize(ref int value, int bits)
		{
		}

		public void WriteUInt(uint value, int bits)
		{
		}

		public uint ReadUInt(int bits)
		{
			return 0u;
		}

		public void WriteUInt(uint value)
		{
		}

		public uint ReadUInt()
		{
			return 0u;
		}

		public void WriteInt_Shifted(int value, int bits, int shift)
		{
		}

		public int ReadInt_Shifted(int bits, int shift)
		{
			return 0;
		}

		public void WriteInt(int value, int bits)
		{
		}

		public int ReadInt(int bits)
		{
			return 0;
		}

		public void WriteInt(int value)
		{
		}

		public int ReadInt()
		{
			return 0;
		}

		public void WriteULong(ulong value, int bits)
		{
		}

		public ulong ReadULong(int bits)
		{
			return 0uL;
		}

		public void WriteULong(ulong value)
		{
		}

		public ulong ReadULong()
		{
			return 0uL;
		}

		public void WriteLong(long value, int bits)
		{
		}

		public long ReadLong(int bits)
		{
			return 0L;
		}

		public void WriteLong(long value)
		{
		}

		public long ReadLong()
		{
			return 0L;
		}

		public void WriteFloat(float value)
		{
		}

		public float ReadFloat()
		{
			return 0f;
		}

		public void WriteDouble(double value)
		{
		}

		public double ReadDouble()
		{
			return 0.0;
		}

		public void WriteByteArray(byte[] from)
		{
		}

		public void WriteByteArray(byte[] from, int count)
		{
		}

		public void WriteByteArray(byte[] from, int offset, int count)
		{
		}

		public byte[] ReadByteArray(int size)
		{
			return null;
		}

		public void ReadByteArray(byte[] to)
		{
		}

		public void ReadByteArray(byte[] to, int count)
		{
		}

		public void ReadByteArray(byte[] to, int offset, int count)
		{
		}

		public void WriteByteArrayWithPrefix(byte[] array)
		{
		}

		public void WriteByteArrayLengthPrefixed(byte[] array, int maxLength)
		{
		}

		public byte[] ReadByteArrayWithPrefix()
		{
			return null;
		}

		public void WriteString(string value, Encoding encoding)
		{
		}

		public void WriteString(string value, Encoding encoding, int length)
		{
		}

		public void WriteString(string value)
		{
		}

		public string ReadString(Encoding encoding)
		{
			return null;
		}

		public string ReadString()
		{
			return null;
		}

		public void WriteGuid(Guid guid)
		{
		}

		public Guid ReadGuid()
		{
			return default(Guid);
		}

		public void WriteEndPoint(UdpEndPoint endpoint)
		{
		}

		public UdpEndPoint ReadEndPoint()
		{
			return default(UdpEndPoint);
		}

		private void InternalWriteByte(byte value, int bits)
		{
		}

		public static void WriteByteAt(byte[] data, int ptr, int bits, byte value)
		{
		}

		private byte InternalReadByte(int bits)
		{
			return 0;
		}

		public void Dispose()
		{
		}
	}
}
