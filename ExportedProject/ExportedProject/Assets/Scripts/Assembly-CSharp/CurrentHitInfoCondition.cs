using UnityEngine;

public class CurrentHitInfoCondition : Condition
{
	private enum Mode
	{
		None = 0,
		HitType = 1,
		Unblockability = 2
	}

	[SerializeField]
	private Mode conditionMode;

	[SerializeField]
	private HitType hitType;

	[SerializeField]
	private bool isUnblockable;

	private HitInfo currentHitInfo;

	private Actor actor;

	public override bool Evaluate(object context)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	private bool IsCorrectHitType()
	{
		return false;
	}

	private bool IsUnblockable()
	{
		return false;
	}
}
