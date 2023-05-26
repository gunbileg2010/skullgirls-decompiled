using System;

[Serializable]
public struct FixedFraction
{
	public Fixed numerator;

	public int denominator;

	public static Fixed operator *(FixedFraction a, int b)
	{
		return default(Fixed);
	}

	public static Fixed operator *(int a, FixedFraction b)
	{
		return default(Fixed);
	}

	public FixedFraction(Fixed numerator, int denominator)
	{
	}

	public Fixed GetValue()
	{
		return default(Fixed);
	}

	public override string ToString()
	{
		return null;
	}
}
