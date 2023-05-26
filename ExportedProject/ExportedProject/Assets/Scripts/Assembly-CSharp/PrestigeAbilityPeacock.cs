using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PrestigeAbilityPeacock : PrestigeAbility
{
	[SerializeField]
	private EnrageModifier enrageModifier;

	[SerializeField]
	private PrecisionModifier precisionModifier;

	[SerializeField]
	private HasteModifier hasteModifier;

	private Fixed cachedBuffChance;

	private List<Modifier> buffList;

	public void Awake()
	{
	}

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

	private void OnActorLandedHit(object passed)
	{
	}

	private void OnSpecialUsed(object passed)
	{
	}

	private void InitBuffList()
	{
	}
}
