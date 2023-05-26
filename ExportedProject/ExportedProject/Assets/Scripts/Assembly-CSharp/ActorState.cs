using System.Collections.Generic;
using System.IO;

public class ActorState
{
	public int index;

	public ActorState next;

	public List<ActorState> transitions;

	public List<Motion> motions;

	public List<uint> tags;

	private string name;

	private List<AniFrameHolder> frameOrder;

	public void ReadFromFile(BinaryReader reader, List<AniFrame> aniFrames)
	{
	}

	public void Clear()
	{
	}

	public bool HasTag(string tagString)
	{
		return false;
	}

	public bool HasTag(uint tag)
	{
		return false;
	}

	public int RepeatsFor(AnimationStatus status)
	{
		return 0;
	}

	public void RestartFor(AnimationStatus status)
	{
	}

	public void AdvanceFor(AnimationStatus status)
	{
	}

	public bool NewHitFor(AnimationStatus status)
	{
		return false;
	}

	public void SetMaxRepeatsFor(AnimationStatus status, int r)
	{
	}

	public bool IsFinishedFor(AnimationStatus status)
	{
		return false;
	}

	public AniFrameHolder GetFrameHolderFor(AnimationStatus status)
	{
		return null;
	}

	public int GetLengthInFrames()
	{
		return 0;
	}

	public AniFrameHolder GetFrameHolderByNumber(int index)
	{
		return null;
	}

	public void SetFrameToNumber(int number, AnimationStatus status)
	{
	}

	public void SetName(string name)
	{
	}

	public string GetName()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
