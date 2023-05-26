using System.IO;
using UnityEngine;

public class PrestigeAbilityRoboFortune : PrestigeAbility
{
	[SerializeField]
	private ReflectModifier reflectModifier;

	[SerializeField]
	private PrecisionModifier precisionModifier;

	private Fixed cachedReflectPerDebuff;

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

	private void OnModifierApplied(object passed)
	{
	}

	private void OnActorWasHit(object passed)
	{
	}

	private Fixed CalculateReflectMultiplier()
	{
		return default(Fixed);
	}

	private int GetNumberOfBuffs(Actor actor)
	{
		return 0;
	}
}
