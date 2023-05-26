using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightResultsPopup : SGUGUIPopup
{
	private const string SAVEKEY_MAXLEVELPOPUP_SEENONCE = "HasSeenMaxLevelHintOnce";

	[SerializeField]
	private AnimationHelper animDriver;

	[SerializeField]
	private LocalizedUGUIText headerText;

	[SerializeField]
	private FightResultsPopupPanel[] panels;

	[SerializeField]
	private GameObject buttonsGO;

	[SerializeField]
	private GameObject continueButtonGO;

	[SerializeField]
	private GameObject replayButtonGO;

	[SerializeField]
	private GameObject quitButtonGO;

	[SerializeField]
	private EnergyUI replayEnergyUI;

	[SerializeField]
	private FightResultsNotification notificationPrototype;

	[SerializeField]
	private Sprite challengeIcon;

	[SerializeField]
	private Sprite completedChallengeIcon;

	[SerializeField]
	private Sprite completedMatchChallengeIcon;

	[SerializeField]
	private float notificationHideDelay;

	[SerializeField]
	private PopupData hitMaxLevelPopup;

	public const float kDelayPerNotif = 0.2f;

	private bool fightInProgress;

	private FightResultServerData fightResultServerData;

	private bool showCharacterXp;

	private bool showCharacterHitMaxLevel;

	private Character firstFoundCharacterHittingMax;

	private List<FightResultsNotification> fightResultNotifications;

	private int prevNavConfig;

	private string prevCurrencyConfig;

	private bool onContinueHidePopup;

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

	public IEnumerator ShowResultsSequence(WinState winState, Team playerTeam, Team enemyTeam, FightResultServerData fightResultData, bool isTutorial = false)
	{
		return null;
	}

	public void UGUI_ContinuePressed()
	{
	}

	public void UGUI_RetryPressed()
	{
	}

	public void UGUI_QuitPressed()
	{
	}

	public void UGUI_ConsumableSizzleClicked(Transform contextualPopupSpawnPos)
	{
	}

	public override void Back()
	{
	}

	public void ShowUpdatedChallenges(float notifDelay = 0f)
	{
	}

	public void ShowFightChallengeNotification(Challenge challenge, float delay = 0f)
	{
	}

	public void ShowNotification(Sprite sprite, string title, string info, float delay = 0f)
	{
	}

	public void CleanupNotifications()
	{
	}

	public void SetButtonConfiguration(bool continueButton, bool replayButton, bool quitButton)
	{
	}

	public void SetReplayEnergyCost(int value)
	{
	}

	public GameObject GetReplayButton()
	{
		return null;
	}

	private void Cleanup()
	{
	}

	public void HidePopup(bool retryFight = false)
	{
	}

	private void FinishHidePopupCallback(bool retryFight)
	{
	}
}
