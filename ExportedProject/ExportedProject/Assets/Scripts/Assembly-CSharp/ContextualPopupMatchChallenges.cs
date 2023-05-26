using System.Collections.Generic;
using UnityEngine;

public class ContextualPopupMatchChallenges : ContextualPopupItem
{
	[SerializeField]
	private List<StatusItemWithReward> matchChallengeStatusItems;

	public void Populate(SGMatch match)
	{
	}
}
