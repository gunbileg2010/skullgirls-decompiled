using System;
using UnityEngine;

[Serializable]
public struct Fixed
{
	public static readonly Fixed Zero;

	public static readonly Fixed One;

	public static readonly Fixed Half;

	public static readonly Fixed Eighth;

	public static readonly Fixed Hundredth;

	public static readonly Fixed MaxValue;

	public static readonly Fixed MinValue;

	[SerializeField]
	public int value;

	private const int SHIFT_AMOUNT = 11;

	private const int ONE = 2048;

	private const float ONEF = 2048f;

	private const int WHOLENUM_MASK = -2048;

	private const int PI = 6434;

	private const int TWOPI = 12868;

	private const int PI_OVER_2 = 3217;

	private const int DEG_90 = 184320;

	private const int DEG_180 = 368640;

	private const int DEG_270 = 552960;

	private const int DEG_360 = 737280;

	private static int[] s_sinTable;

	static Fixed()
	{
	}

	public static Fixed operator *(Fixed a, Fixed b)
	{
		return default(Fixed);
	}

	public static Fixed operator /(Fixed a, Fixed b)
	{
		return default(Fixed);
	}

	public static Fixed operator +(Fixed a, Fixed b)
	{
		return default(Fixed);
	}

	public static Fixed operator -(Fixed a, Fixed b)
	{
		return default(Fixed);
	}

	public static Fixed operator -(Fixed a)
	{
		return default(Fixed);
	}

	public static bool operator ==(Fixed a, Fixed b)
	{
		return false;
	}

	public static bool operator !=(Fixed a, Fixed b)
	{
		return false;
	}

	public static bool operator >(Fixed a, Fixed b)
	{
		return false;
	}

	public static bool operator <(Fixed a, Fixed b)
	{
		return false;
	}

	public static bool operator >=(Fixed a, Fixed b)
	{
		return false;
	}

	public static bool operator <=(Fixed a, Fixed b)
	{
		return false;
	}

	public static Fixed operator %(Fixed a, Fixed b)
	{
		return default(Fixed);
	}

	public static explicit operator int(Fixed src)
	{
		return 0;
	}

	public static explicit operator Fixed(float src)
	{
		return default(Fixed);
	}

	public static explicit operator Fixed(int src)
	{
		return default(Fixed);
	}

	public static explicit operator float(Fixed src)
	{
		return 0f;
	}

	public static Fixed Pow(Fixed f, Fixed p)
	{
		return default(Fixed);
	}

	public static Fixed Min(Fixed a, Fixed b)
	{
		return default(Fixed);
	}

	public static Fixed Max(Fixed a, Fixed b)
	{
		return default(Fixed);
	}

	public static Fixed Abs(Fixed a)
	{
		return default(Fixed);
	}

	public static Fixed Floor(Fixed a)
	{
		return default(Fixed);
	}

	public static Fixed Ceiling(Fixed a)
	{
		return default(Fixed);
	}

	public static Fixed LerpUnclamped(Fixed a, Fixed b, Fixed percent)
	{
		return default(Fixed);
	}

	public static Fixed Lerp(Fixed a, Fixed b, Fixed percent)
	{
		return default(Fixed);
	}

	public static Fixed InvLerp(Fixed a, Fixed b, Fixed percent)
	{
		return default(Fixed);
	}

	public static Fixed Clamp(Fixed a, Fixed from, Fixed to)
	{
		return default(Fixed);
	}

	public static Fixed Clamp01(Fixed a)
	{
		return default(Fixed);
	}

	public static Fixed Atan2(Fixed y, Fixed x)
	{
		return default(Fixed);
	}

	public static Fixed ReadDigit(Fixed value, int digitToRead)
	{
		return default(Fixed);
	}

	public static Fixed Atan2_Deg(Fixed y, Fixed x)
	{
		return default(Fixed);
	}

	public static bool WillAdditionExceedBounds(Fixed a, Fixed b)
	{
		return false;
	}

	public static bool WillMultiplicationExceedBounds(Fixed a, Fixed b)
	{
		return false;
	}

	public Fixed(Fixed f)
	{
	}

	public Fixed(float f)
	{
	}

	public int Sign()
	{
		return 0;
	}

	public Fixed Clamp(Fixed min, Fixed max)
	{
		return default(Fixed);
	}

	public float GetFloat()
	{
		return 0f;
	}

	public void SetRawValue(int val)
	{
	}

	public int GetRawValue()
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public string ToString(bool dummy)
	{
		return null;
	}

	public Fixed Sqrt()
	{
		return default(Fixed);
	}

	public Fixed Abs()
	{
		return default(Fixed);
	}

	public Fixed WrapAngle()
	{
		return default(Fixed);
	}

	public Fixed WrapAngle_Deg()
	{
		return default(Fixed);
	}

	public Fixed Deg2Rad()
	{
		return default(Fixed);
	}

	public Fixed Rad2Deg()
	{
		return default(Fixed);
	}

	public Fixed Sin()
	{
		return default(Fixed);
	}

	public Fixed Sin_Deg()
	{
		return default(Fixed);
	}

	public Fixed Cos()
	{
		return default(Fixed);
	}

	public Fixed Cos_Deg()
	{
		return default(Fixed);
	}

	public Fixed Tan()
	{
		return default(Fixed);
	}

	public Fixed Tan_Deg()
	{
		return default(Fixed);
	}

	public Fixed Asin()
	{
		return default(Fixed);
	}

	public Fixed Asin_Deg()
	{
		return default(Fixed);
	}

	private Fixed(int i, bool rawValue = true)
	{
	}

	private Fixed(long l)
	{
	}

	private Fixed _Sqrt(int numberOfIterations)
	{
		return default(Fixed);
	}

	private static Fixed _SinDeg(int i)
	{
		return default(Fixed);
	}

	private static Fixed _CosDeg(int i)
	{
		return default(Fixed);
	}
}
