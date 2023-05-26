using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActRewardsChecklistPopup : RewardsChecklistPopup
{
	[SerializeField]
	private ScrollRect scrollRect;

	public override void Show()
	{
	}

	protected List<Dictionary<string, object>> GetDataListFromAct(Act act)
	{
		return null;
	}
}
