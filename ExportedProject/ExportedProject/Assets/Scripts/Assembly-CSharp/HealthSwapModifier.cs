using UnityEngine;

public class HealthSwapModifier : Modifier
{
	public enum Mode
	{
		SwapHealth = 0,
		MirrorHealth = 1
	}

	[SerializeField]
	private Mode modifyMode;

	private const float kMinPercentLife = 0.01f;

	public override string ToString()
	{
		return null;
	}

	public override string GetDisplayName()
	{
		return null;
	}

	protected override void Apply()
	{
	}
}
