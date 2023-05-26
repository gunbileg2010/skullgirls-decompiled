using System.IO;
using UnityEngine;

public class TimeStopModifier : Modifier
{
	[SerializeField]
	private Fixed superFlashType;

	private bool initialized;

	private bool timeStopStarted;

	[SerializeField]
	private int timeStopFrames;

	private int timeStopFramesLeft;

	private const int kMinFramesUntilUnfreezeAllowed = 5;

	private const int kFakeHitLength = 12;

	public override string ToString()
	{
		return null;
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

	private void OnFightFrameUpdated(object passed)
	{
	}

	private void CleanUpAndRemove()
	{
	}

	private bool ActorOrChildHasHitbox(Actor actor)
	{
		return false;
	}

	private void StartTimeStop()
	{
	}

	protected override void Unapply()
	{
	}
}
