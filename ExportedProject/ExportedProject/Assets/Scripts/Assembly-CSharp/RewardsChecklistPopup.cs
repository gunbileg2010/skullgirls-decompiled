using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardsChecklistPopup : SGUGUIPopup
{
	[SerializeField]
	protected RewardsChecklistItem itemPrototype;

	[SerializeField]
	protected Image backgroundImage;

	[SerializeField]
	protected RectTransform frameTransform;

	protected const string kHeaderKey = "header";

	protected const string kCompletedKey = "completed";

	protected const string kLootsKey = "loots";

	protected int itemCounter;

	protected List<RewardsChecklistItem> items;

	protected override void Awake()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	protected virtual void PopulateFromDataList(List<Dictionary<string, object>> dataList)
	{
	}

	protected virtual void ClearItems()
	{
	}

	protected RewardsChecklistItem GetItem()
	{
		return null;
	}
}
