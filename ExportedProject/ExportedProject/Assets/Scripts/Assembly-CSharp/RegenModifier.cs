using System.IO;
using UnityEngine;

public class RegenModifier : Modifier
{
	[SerializeField]
	private Fixed percentMaxLife;

	[SerializeField]
	private bool perSecond;

	private Fixed showTime;

	private Fixed regenRate;

	private Fixed gainedLife;

	private float gainedLifePercent;

	private int displayPoints;

	private Fixed displayTimer;

	public override ModifierType GetModifierType()
	{
		return default(ModifierType);
	}

	public Fixed GetPercentMaxLife()
	{
		return default(Fixed);
	}

	public override string ToString()
	{
		return null;
	}

	public override string GetDisplayName()
	{
		return null;
	}

	public override bool ShouldStackWith(Modifier toStack)
	{
		return false;
	}

	public override void SaveState(BinaryWriter writer)
	{
	}

	public override void LoadState(BinaryReader reader)
	{
	}

	public override bool CompareStates(BinaryReader readerA, BinaryReader readerB)
	{
		return false;
	}

	public void SetPerSecond(bool onOff)
	{
	}

	public void SetPercentMaxLife(Fixed newPercent)
	{
	}

	protected override void Apply()
	{
	}

	protected override void OnFrameUpdate()
	{
	}

	protected override void Unapply()
	{
	}

	private void ShowHUDDamage(int pointsToShow)
	{
	}

	private void ApplyPointsToLifebar(int lifebarPoints, bool instantaneous)
	{
	}

	private void UpdateRegenRate()
	{
	}
}
