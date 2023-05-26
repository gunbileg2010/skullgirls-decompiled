using System;
using UnityEngine;

public interface IDataWriter : IDisposable
{
	void Write(bool b);

	void Write(byte b);

	void Write(char c);

	void Write(float f);

	void Write(int i);

	void Write(long l);

	void Write(uint ui);

	void Write(ulong ul);

	void Write(string s);

	void Write(Vector3 v);
}
