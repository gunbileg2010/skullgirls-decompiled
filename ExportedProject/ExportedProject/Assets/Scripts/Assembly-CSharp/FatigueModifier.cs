public class FatigueModifier : Modifier
{
	private const int kStunChancePercent = 50;

	public override ModifierType GetModifierType()
	{
		return default(ModifierType);
	}

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

	protected override void OnFrameUpdate()
	{
	}
}
