using System.IO;

public class PrestigeAbilityCerebella : PrestigeAbility
{
	private Fixed bonusMultiplier;

	private Fixed bonusDamageApplied;

	private bool throwCounted;

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

	protected override void ApplyImmediateEffects()
	{
	}

	protected override void ApplyEffects()
	{
	}

	protected override void UnapplyEffects()
	{
	}

	private void OnDamageBoostRecalcNeeded(object passed)
	{
	}

	private void OnFightFrameUpdated(object passed)
	{
	}

	private Fixed CalculateDamageBoost()
	{
		return default(Fixed);
	}
}
