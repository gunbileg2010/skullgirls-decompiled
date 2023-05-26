using System.IO;

public class PrestigeAbilityAnnie : PrestigeAbility
{
	private int bonusAppliedFrame;

	private Fixed cachedBonusDamage;

	private Fixed lastStarPower;

	public override void Init(Actor actor, int level)
	{
	}

	public override void SaveState(BinaryWriter writer)
	{
	}

	public override void LoadState(BinaryReader reader)
	{
	}

	public override bool CompareState(BinaryReader readerA, BinaryReader readerB)
	{
		return false;
	}

	protected override object[] GetDescriptionSubstitutions()
	{
		return null;
	}

	protected override void SetupChargeEventListeners()
	{
	}

	protected override void CleanUpChargeEventListeners()
	{
	}

	protected override void SetupEffectListeners()
	{
	}

	protected override void CleanUpEffectListeners()
	{
	}

	protected override void ApplyEffects()
	{
	}

	protected override void UnapplyEffects()
	{
	}

	private void OnFightFrameUpdated(object passed)
	{
	}

	private void OnActorAboutToLandHit(object passed)
	{
	}
}
