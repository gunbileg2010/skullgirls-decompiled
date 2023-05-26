using System.IO;
using UnityEngine;

public class PrestigeAbilityParasoul : PrestigeAbility
{
	[SerializeField]
	private ChildDistanceCondition childDistanceCondition;

	[SerializeField]
	private PrecisionModifier precisionModifier;

	private uint tearSpawned;

	private int cachedFramesNeeded;

	private int timer;

	private TriggerEventData fightFrameUpdated;

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

	private void OnAniEvent(object passed)
	{
	}

	private void OnFightFrameUpdated(object passed)
	{
	}
}
