using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BattleLobbyScreen : MonoBehaviour
{
	[Serializable]
	public struct OpponentInfo
	{
		public GameObject parentObject;

		public PlayerSummary opponentSummary;

		public Text opponentRating;

		public GameObject victoryStatusParent;

		public LocalizedUGUIText victoryStatusString;
	}

	public const float kOpponentSlideInDelay = 0.25f;

	[SerializeField]
	private Stage bgStage;

	[SerializeField]
	private Transform cameraMarker;

	[SerializeField]
	private Transform defaultCameraMarker;

	[SerializeField]
	private PlayerSummary localPlayerSummery;

	[SerializeField]
	private LocalizedUGUIText playerLabRating;

	[SerializeField]
	private LocalizedUGUIText battlesInSeasonCountLabel;

	[SerializeField]
	private LocalizedUGUIText playerWinStreakText;

	[SerializeField]
	private LocalizedUGUIText playerRiftCoinMultiplierText;

	[SerializeField]
	private LocalizedUGUIText playerHpStreakBonus;

	[SerializeField]
	private UIGradient32 playerHpStreakBonusGradient;

	[SerializeField]
	private UIGradient32 playerHpStreakBonuTitleGradient;

	[SerializeField]
	private LocalizedUGUIText playerAtkStreakBonus;

	[SerializeField]
	private UIGradient32 playerAtkStreakBonusGradient;

	[SerializeField]
	private UIGradient32 playerAtkStreakBonusTitleGradient;

	[SerializeField]
	private GameObject winStreakResetParent;

	[SerializeField]
	private TimerUI winStreakResetTimer;

	[SerializeField]
	private Button defenseButton;

	[SerializeField]
	private TimerUI seasonTimerUI;

	[SerializeField]
	private AdvancedButton claimFreeTicketsButton;

	[SerializeField]
	private GameObject claimFreeTicketsHelpButton;

	[SerializeField]
	private Badge claimFreeTicketBadge;

	[SerializeField]
	private BattleLobbyOpponentInfo[] opponentInfoDisplays;

	[SerializeField]
	private AdvancedButton refreshButton;

	[SerializeField]
	private GameObject choseOpponentParent;

	[SerializeField]
	private BattleLobbyOpponentInfo inProgressOpponentInfo;

	[SerializeField]
	private Button battleButton;

	[SerializeField]
	private GameObject inProgressParent;

	[SerializeField]
	private LocalizedUGUIText playerWinPrediction;

	[SerializeField]
	private LocalizedUGUIText playerLossPrediction;

	[SerializeField]
	private LocalizedUGUIText scoreText;

	[SerializeField]
	private GameObject revengeScoreToBeatParent;

	[SerializeField]
	private LocalizedUGUIText revengeScoreToBeatText;

	[SerializeField]
	private RiftBattleStartPopupData riftBattleStartPopupData;

	[SerializeField]
	private PopupData battleResultPopupData;

	[SerializeField]
	private PopupData rewardsDataPopup;

	[SerializeField]
	private PopupData defenseBaseHistoryPopup;

	[SerializeField]
	private Badge defenseBaseHistoryBadge;

	[SerializeField]
	private MasterPopupData buyBattleTicketPopup;

	[SerializeField]
	private PopupData riftRatingInfoPopup;

	[SerializeField]
	private PopupData winStreakInfoPopup;

	[SerializeField]
	private Color battlesInSeasonBelowMinColor;

	[SerializeField]
	private Color battlesInSeasonReqsMetColor;

	public Action OnBattleStarted;

	private RiftBattleEventData riftBattleEventData;

	private const int kDefaultTopBarConfig = 1048588;

	private const int kStartBattleTopBarConfig = 1048604;

	private static BattleInstanceServerData returningFromDefenseMapBattleInstance;

	private bool exitedScreenDueToEventServerError;

	private void Awake()
	{
	}

	public Transform GetIndicatorPosition(IndicatorTarget target)
	{
		return null;
	}

	public void UGUI_DefenseButton()
	{
	}

	public void UGUI_HistoryButton()
	{
	}

	public void UGUI_SelectOpponent(int index)
	{
	}

	public void UGUI_SelectOpponent(int index, BattleInstanceServerData revengeBattle)
	{
	}

	public void UGUI_ViewRewards()
	{
	}

	public void UGUI_BattleButtonPressed()
	{
	}

	public void UGUI_RatingInfoPressed()
	{
	}

	public void UGUI_StreakInfoPressed()
	{
	}

	public void UGUI_RefreshPressed()
	{
	}

	public void UGUI_ClaimButtonPressed()
	{
	}

	public void BattleInstanceClaimed()
	{
	}

	public static void ReturningFromDefenseHistory(BattleInstanceServerData battleInstance)
	{
	}

	public static BattleInstanceServerData GetDefenseHistoryBattleToFocus()
	{
		return null;
	}

	private IEnumerator OnStateEntered(IGameState prevState, object context)
	{
		return null;
	}

	private IEnumerator OnStateExited(IGameState nextState)
	{
		return null;
	}

	private IEnumerator RefreshEventsAndBattlesFromServer()
	{
		return null;
	}

	private void RefreshUI(bool enteredScreen = false)
	{
	}

	private void RefreshClaimButton()
	{
	}

	private void HandleUnfinishedMap()
	{
	}

	private void GoToDefenseMap()
	{
	}

	private void ShowPurchaseBattleTicketPopup(int opponentIndex, BattleInstanceServerData revengeBattle = null)
	{
	}

	private void ResetToDefaultTopBarConfig()
	{
	}
}
