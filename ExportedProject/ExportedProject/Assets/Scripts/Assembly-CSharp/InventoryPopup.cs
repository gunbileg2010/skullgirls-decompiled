using UnityEngine;
using UnityEngine.UI;

public class InventoryPopup : RewardsChecklistPopup
{
	[SerializeField]
	private ScrollRect scrollRect;

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	private void OnPreStateChanged(string oldState, string newState)
	{
	}
}
