using System;
using UdpKit;
using UnityEngine;

public class UdpPacketReader : IDataReader, IDisposable
{
	private UdpPacket packet;

	public UdpPacketReader(UdpPacket packet)
	{
	}

	public void Dispose()
	{
	}

	public bool ReadBoolean()
	{
		return false;
	}

	public byte ReadByte()
	{
		return 0;
	}

	public char ReadChar()
	{
		return '\0';
	}

	public float ReadSingle()
	{
		return 0f;
	}

	public int ReadInt32()
	{
		return 0;
	}

	public long ReadInt64()
	{
		return 0L;
	}

	public uint ReadUInt32()
	{
		return 0u;
	}

	public ulong ReadUInt64()
	{
		return 0uL;
	}

	public string ReadString()
	{
		return null;
	}

	public Vector3 ReadVector3()
	{
		return default(Vector3);
	}
}
