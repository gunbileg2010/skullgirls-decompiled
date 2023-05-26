using System;

public class SystemRandomizer : Randomizer
{
	private Random random;

	public override float GetValue()
	{
		return 0f;
	}

	public override int GetIntValue()
	{
		return 0;
	}

	protected override void ChangeSeed(int? seed)
	{
	}
}
