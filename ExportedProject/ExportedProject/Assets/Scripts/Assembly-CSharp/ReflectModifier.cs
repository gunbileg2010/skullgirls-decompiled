using System.IO;
using UnityEngine;

public class ReflectModifier : Modifier
{
	[SerializeField]
	protected Fixed percentage;

	[SerializeField]
	protected bool reflectToAllies;

	protected bool initialized;

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

	public void SetPercentage(Fixed newPercentage)
	{
	}

	protected override void Apply()
	{
	}

	protected virtual void OnActorWasHit(object passed)
	{
	}

	protected override void OnModifierDestroy()
	{
	}

	protected void TakeReflectedDamage()
	{
	}
}
