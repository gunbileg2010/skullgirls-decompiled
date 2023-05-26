using System.IO;
using UnityEngine;

public class PrestigeAbilityFukua : PrestigeAbility
{
	[SerializeField]
	private SuperbarModifier superbarModifier;

	[SerializeField]
	private HealBlockModifier healBlockModifier;

	private Fixed cachedMeterDrain;

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

	protected override void ApplyEffects()
	{
	}

	private void OnBlockbusterUsed(object passed)
	{
	}
}
