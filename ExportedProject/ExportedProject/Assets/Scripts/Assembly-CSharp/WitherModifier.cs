using System.IO;
using UnityEngine;

public class WitherModifier : Modifier
{
	[SerializeField]
	private Fixed value;

	[SerializeField]
	private bool perSecond;

	private Fixed damageRate;

	private Fixed reduceTime;

	private Fixed reductionTimer;

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

	protected override void Apply()
	{
	}

	protected override void OnFrameUpdate()
	{
	}

	protected override void Unapply()
	{
	}

	private void RemoveMeterFromGear(float meterPercent)
	{
	}

	private void UpdateDamageRate()
	{
	}
}
