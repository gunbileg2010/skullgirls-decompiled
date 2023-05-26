using UnityEngine;
using UnityEngine.UI;

public class RiftBattleResultsPopup : SGUGUIPopup
{
	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private Animation windowAnim;

	[SerializeField]
	private LocalizedUGUIText headerText;

	[SerializeField]
	private PlayerSummary playerSummary;

	[SerializeField]
	private PlayerSummary opponentSummary;

	[SerializeField]
	private AnimDrivenTallyText userRatingAmount;

	[SerializeField]
	private LocalizedUGUIText userWinLabRankDelta;

	[SerializeField]
	private LocalizedUGUIText userLossLabRankDelta;

	[SerializeField]
	private LocalizedUGUIText userScoreAmount;

	[SerializeField]
	private GameObject opponentRevengeScoreToBeatParent;

	[SerializeField]
	private LocalizedUGUIText opponentRevengeScoreToBeatText;

	private RiftBattleStateServerData battleState;

	private BattleInstanceServerData finishedBattleInstance;

	private XsProfile opponentInfo;

	private float cachedBackgroundAlpha;

	protected override void Awake()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}
}
