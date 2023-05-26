using UnityEngine;

public class StagePositionCondition : Condition
{
	private enum DistanceCheckType
	{
		CLOSER_THAN = 0,
		FARTHER_THAN = 1
	}

	[SerializeField]
	private DistanceCheckType checkType;

	[SerializeField]
	private Fixed stageDistancePercent;

	[SerializeField]
	private bool localSide;

	private const int kLeftStageEnd = -2000;

	private const int kRightStageEnd = 2000;

	public override bool Evaluate(object context)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
