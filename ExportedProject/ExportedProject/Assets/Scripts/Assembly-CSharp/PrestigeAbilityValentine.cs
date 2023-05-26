using System.IO;
using UnityEngine;

public class PrestigeAbilityValentine : PrestigeAbility
{
	[SerializeField]
	private ResurrectionModifier resurrectionModifier;

	[SerializeField]
	private RegenModifier regenModifier;

	private bool diedThisEvent;

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

	protected override void ApplyImmediateEffects()
	{
	}

	protected override void ApplyEffects()
	{
	}

	private void OnHealthChanged(object passed)
	{
	}

	private void OnPreAboutToDie(object passed)
	{
	}

	private void OnFightFrameUpdated(object passed)
	{
	}

	private int GetLifebarPercentDifference(Actor actor)
	{
		return 0;
	}
}
