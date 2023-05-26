using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RiftBattleDefenseHistoryPopup : SGUGUIPopup
{
	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private RiftBattleDefenseHistoryView itemPrototype;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private GameObject noFightHistoryGO;

	[SerializeField]
	private const string kNoHistoryKey = "RiftBattle_Defense_History_NoFights";

	[SerializeField]
	private ContextualTutorial contextualTutorial;

	protected int itemCounter;

	protected List<RiftBattleDefenseHistoryView> items;

	protected override void Awake()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	private void OnStateChanged(string prevState, string nextState)
	{
	}

	private void ClearItems()
	{
	}

	private RiftBattleDefenseHistoryView GetItem()
	{
		return null;
	}
}
