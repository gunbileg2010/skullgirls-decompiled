using System.Collections.Generic;
using UnityEngine;

public class FightResultsRiftBattleSubTally : MonoBehaviour
{
	[SerializeField]
	private AnimDrivenTallyText amountLabel;

	[SerializeField]
	private string scoreBreakdownKey;

	[SerializeField]
	private float tallyUpTime;

	[SerializeField]
	private UIGradient32 noPointsVisual;

	[SerializeField]
	private bool hideIfNotPresent;

	[SerializeField]
	private GameObject infoButtonSpacer;

	private float lastValue;

	private int cachedTotalPoints;

	public void Populate(Dictionary<string, int> scoreBreakdown)
	{
	}

	public void SetPercent(float value)
	{
	}

	public int GetTotalPoints()
	{
		return 0;
	}

	public float GetTallyUpTime()
	{
		return 0f;
	}

	private void PopulateGradients()
	{
	}
}
