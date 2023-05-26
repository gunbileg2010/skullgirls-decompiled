using System.IO;
using UnityEngine;

public class PrestigeAbilityUmbrella : PrestigeAbility
{
	[SerializeField]
	private RegenModifier regenModifier;

	[SerializeField]
	private SlimeModifier slimeModifier;

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

	private void OnActorLandedHit(object passed)
	{
	}

	private void OnHungernChargeChanged(object passed)
	{
	}

	private Fixed GetHungernChargePercentDifference(Actor actor)
	{
		return default(Fixed);
	}
}
