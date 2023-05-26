using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardEventDefenseHistoryPopup : SGUGUIPopup
{
	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private FightHistoryView itemPrototype;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private RectTransform scrollRectTransform;

	[SerializeField]
	private GameObject separator;

	[SerializeField]
	private GameObject noFightHistoryGO;

	[SerializeField]
	private LocalizedUGUIText totalPointsText;

	[SerializeField]
	private AdvancedButton claimButton;

	[SerializeField]
	private AdvancedButton okButton;

	[SerializeField]
	private Button closeButton;

	[SerializeField]
	private string riftBattleNoFightHistoryLocalizationKey;

	private LeaderboardEventDefenseHistoryPopupData historyPopupData;

	protected int itemCounter;

	protected List<FightHistoryView> items;

	private long totalPointsEarned;

	protected override void Awake()
	{
	}

	public override void SetData(PopupData newPopupData)
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	private void ClearItems()
	{
	}

	private FightHistoryView GetItem()
	{
		return null;
	}
}
