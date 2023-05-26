using System.Collections.Generic;
using UnityEngine;

public class SetXPBoostPickerPopupInteractiveTutorialAction : SequentialTutorialAction
{
	[SerializeField]
	private bool closeButton;

	[SerializeField]
	private List<int> consumableIndexes;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}
}
