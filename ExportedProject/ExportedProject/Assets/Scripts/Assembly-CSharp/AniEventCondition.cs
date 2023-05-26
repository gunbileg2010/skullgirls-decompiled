using UnityEngine;

public class AniEventCondition : Condition
{
	[SerializeField]
	private string aniEventName;

	private uint aniEvent;

	public override bool Evaluate(object context)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
