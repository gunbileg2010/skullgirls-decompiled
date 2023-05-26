using System;
using UnityEngine;

[Serializable]
public struct Fixed3
{
	public static readonly Fixed3 Zero;

	public static readonly Fixed3 One;

	public Fixed x;

	public Fixed y;

	public Fixed z;

	public Fixed3(Fixed _x, Fixed _y, Fixed _z)
	{
	}

	public Fixed3(Fixed _x, Fixed _y)
	{
	}

	public Fixed3(float _x, float _y, float _z)
	{
	}

	public Fixed3(int _x, int _y, int _z)
	{
	}

	public Fixed3(Vector3 v)
	{
	}

	public Fixed Length()
	{
		return default(Fixed);
	}

	public Fixed LengthSq()
	{
		return default(Fixed);
	}

	public Vector3 GetVector3()
	{
		return default(Vector3);
	}

	public static explicit operator Vector3(Fixed3 src)
	{
		return default(Vector3);
	}

	public static explicit operator Vector2(Fixed3 src)
	{
		return default(Vector2);
	}

	public static explicit operator Fixed3(Vector3 src)
	{
		return default(Fixed3);
	}

	public static explicit operator Fixed3(Vector2 src)
	{
		return default(Fixed3);
	}

	public static explicit operator Fixed3(Fixed2 src)
	{
		return default(Fixed3);
	}

	public static Fixed3 Min(Fixed3 a, Fixed3 b)
	{
		return default(Fixed3);
	}

	public static Fixed3 Max(Fixed3 a, Fixed3 b)
	{
		return default(Fixed3);
	}

	public static Fixed3 Lerp(Fixed3 a, Fixed3 b, Fixed percent)
	{
		return default(Fixed3);
	}

	public static Fixed3 operator +(Fixed3 a, Fixed3 b)
	{
		return default(Fixed3);
	}

	public static Fixed3 operator -(Fixed3 a, Fixed3 b)
	{
		return default(Fixed3);
	}

	public static Fixed3 operator -(Fixed3 a)
	{
		return default(Fixed3);
	}

	public static Fixed3 operator *(Fixed a, Fixed3 b)
	{
		return default(Fixed3);
	}

	public static Fixed3 operator *(Fixed3 a, Fixed b)
	{
		return default(Fixed3);
	}

	public static Fixed3 operator /(Fixed3 a, Fixed b)
	{
		return default(Fixed3);
	}

	public static bool operator ==(Fixed3 a, Fixed3 b)
	{
		return false;
	}

	public static bool operator !=(Fixed3 a, Fixed3 b)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static Fixed3 Normalize(Fixed3 a)
	{
		return default(Fixed3);
	}

	public override string ToString()
	{
		return null;
	}

	public Fixed3 GetCopyWithXInverted()
	{
		return default(Fixed3);
	}
}
