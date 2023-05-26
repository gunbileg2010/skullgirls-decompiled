using UnityEngine;

public static class Scale
{
	public const float kZUnitsPerUUnit = 16f;

	public const float defaultStageWidthUUnits = 234.375f;

	public const float defaultStageHeightUUnits = 125f;

	private const float kInvZUnitsPerUUnit = 0.0625f;

	private static readonly Fixed kInvZUnitsPerUUnitFixed;

	public static float FromZUnits(float zUnits)
	{
		return 0f;
	}

	public static Fixed FromZUnits(Fixed zUnits)
	{
		return default(Fixed);
	}

	public static Vector2 FromZUnits(Vector2 zUnitsVector)
	{
		return default(Vector2);
	}

	public static Fixed2 FromZUnits(Fixed2 zUnitsVector)
	{
		return default(Fixed2);
	}

	public static float ToZUnits(float uUnits)
	{
		return 0f;
	}

	public static Fixed ToZUnits(Fixed uUnits)
	{
		return default(Fixed);
	}
}
