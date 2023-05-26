using System;
using UnityEngine;

[Serializable]
public struct Fixed2
{
	public static readonly Fixed2 Zero;

	public static readonly Fixed2 One;

	public Fixed x;

	public Fixed y;

	public Fixed2(Fixed _x, Fixed _y)
	{
	}

	public Fixed2(float _x, float _y)
	{
	}

	public Fixed2(Vector2 v)
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

	public Vector2 GetVector2()
	{
		return default(Vector2);
	}

	public static explicit operator Vector2(Fixed2 src)
	{
		return default(Vector2);
	}

	public static explicit operator Fixed2(Vector2 src)
	{
		return default(Fixed2);
	}

	public static explicit operator Fixed2(Fixed3 src)
	{
		return default(Fixed2);
	}

	public static Fixed2 operator +(Fixed2 a, Fixed2 b)
	{
		return default(Fixed2);
	}

	public static Fixed2 operator -(Fixed2 a, Fixed2 b)
	{
		return default(Fixed2);
	}

	public static Fixed2 operator *(Fixed a, Fixed2 b)
	{
		return default(Fixed2);
	}

	public static Fixed2 operator *(Fixed2 a, Fixed b)
	{
		return default(Fixed2);
	}

	public static Fixed2 operator /(Fixed2 a, Fixed b)
	{
		return default(Fixed2);
	}

	public static bool operator ==(Fixed2 a, Fixed2 b)
	{
		return false;
	}

	public static bool operator !=(Fixed2 a, Fixed2 b)
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

	public Fixed2 GetCopyWithXInverted()
	{
		return default(Fixed2);
	}
}
