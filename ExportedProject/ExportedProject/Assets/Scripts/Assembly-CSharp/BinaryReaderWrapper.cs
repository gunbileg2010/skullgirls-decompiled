using System;
using System.IO;
using UnityEngine;

public class BinaryReaderWrapper : IDataReader, IDisposable
{
	private BinaryReader reader;

	public void Dispose()
	{
	}

	public BinaryReaderWrapper()
	{
	}

	public BinaryReaderWrapper(Stream input)
	{
	}

	public BinaryReaderWrapper(BinaryReader binaryReader)
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

	public short ReadInt16()
	{
		return 0;
	}

	public ushort ReadUInt16()
	{
		return 0;
	}

	public int ReadInt32()
	{
		return 0;
	}

	public uint ReadUInt32()
	{
		return 0u;
	}

	public long ReadInt64()
	{
		return 0L;
	}

	public ulong ReadUInt64()
	{
		return 0uL;
	}

	public string ReadString()
	{
		return null;
	}

	public char[] ReadChars(int count)
	{
		return null;
	}

	public Vector3 ReadVector3()
	{
		return default(Vector3);
	}
}
