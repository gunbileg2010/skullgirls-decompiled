using UnityEngine;
using UnityEngine.UI;

public class RiftBattleStartPopup : SGUGUIPopup
{
	[SerializeField]
	protected Image backgroundImage;

	[SerializeField]
	protected RectTransform frameTransform;

	[SerializeField]
	private PlayerSummary playerSummary;

	[SerializeField]
	private MapNodeGraphics bossNodeGraphic;

	[SerializeField]
	private AdvancedButton battleButton;

	[SerializeField]
	private LocalizedUGUIText riftRatingDisplay;

	[SerializeField]
	private Text revengeStakesMultiplier;

	[SerializeField]
	private LocalizedUGUIText playerWinPrediction;

	[SerializeField]
	private LocalizedUGUIText playerLossPrediction;

	[SerializeField]
	private MapNode mapNode;

	private RiftBattleStartPopupData data;

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void UGUI_BattleStart()
	{
	}

	public void UGUI_ShowProfile()
	{
	}

	public void UGUI_Cancel()
	{
	}
}
