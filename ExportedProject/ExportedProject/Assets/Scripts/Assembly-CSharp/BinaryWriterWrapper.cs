using System;
using System.IO;
using UnityEngine;

public class BinaryWriterWrapper : IDataWriter, IDisposable
{
	private BinaryWriter writer;

	public void Dispose()
	{
	}

	public BinaryWriterWrapper()
	{
	}

	public BinaryWriterWrapper(Stream input)
	{
	}

	public BinaryWriterWrapper(BinaryWriter binaryWriter)
	{
	}

	public void Flush()
	{
	}

	public void Write(bool b)
	{
	}

	public void Write(byte b)
	{
	}

	public void Write(char c)
	{
	}

	public void Write(short s)
	{
	}

	public void Write(ushort us)
	{
	}

	public void Write(float f)
	{
	}

	public void Write(int i)
	{
	}

	public void Write(long l)
	{
	}

	public void Write(uint ui)
	{
	}

	public void Write(ulong ul)
	{
	}

	public void Write(string s)
	{
	}

	public void Write(char[] chars)
	{
	}

	public void Write(Vector3 v)
	{
	}
}
