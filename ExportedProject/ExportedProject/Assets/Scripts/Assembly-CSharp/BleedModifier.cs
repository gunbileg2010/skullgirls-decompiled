using System.IO;
using UnityEngine;

public class BleedModifier : Modifier
{
	[SerializeField]
	private BleedType bleedType;

	[SerializeField]
	private Fixed value;

	[SerializeField]
	private bool perSecond;

	[SerializeField]
	private bool preventKill;

	private Fixed showTime;

	private Fixed damageRate;

	private Fixed lostLife;

	private Fixed lostRedLife;

	private int displayPoints;

	private Fixed displayTimer;

	private Fixed redLifeMultiplier;

	public override ModifierType GetModifierType()
	{
		return default(ModifierType);
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

	public void SetValue(Fixed newValue)
	{
	}

	public void SetPreventKill(bool onOff)
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

	private void RemovePointsFromLifebar(int lifebarPoints, Slot slot = Slot.LIFEBAR)
	{
	}

	private void UpdateDamageRate()
	{
	}
}
