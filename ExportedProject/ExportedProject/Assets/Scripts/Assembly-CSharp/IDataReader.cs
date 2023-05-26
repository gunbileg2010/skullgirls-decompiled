using System;
using UnityEngine;

public interface IDataReader : IDisposable
{
	bool ReadBoolean();

	byte ReadByte();

	char ReadChar();

	float ReadSingle();

	int ReadInt32();

	long ReadInt64();

	uint ReadUInt32();

	ulong ReadUInt64();

	string ReadString();

	Vector3 ReadVector3();
}
