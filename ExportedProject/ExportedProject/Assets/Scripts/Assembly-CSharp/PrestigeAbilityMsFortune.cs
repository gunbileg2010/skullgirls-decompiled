using System.IO;
using UnityEngine;

public class PrestigeAbilityMsFortune : PrestigeAbility
{
	[SerializeField]
	private EvasionModifier evasionModifier;

	[SerializeField]
	private GuardBreakModifier guardBreakModifier;

	[SerializeField]
	private Fixed edgeLeeway;

	private int cachedEvasionFrameTimer;

	private int timer;

	private Actor myHead;

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

	protected override void ApplyImmediateEffects()
	{
	}

	private void OnMatchStarted(object passed)
	{
	}

	private void OnFightFrameUpdated(object passed)
	{
	}

	private bool IsAlmostOnEdge(Actor actor)
	{
		return false;
	}
}
