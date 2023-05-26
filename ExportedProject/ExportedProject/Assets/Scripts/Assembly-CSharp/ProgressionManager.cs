using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProgressionManager : MonoBehaviour
{
	[SerializeField]
	private Act advancedTutorialAct;

	[SerializeField]
	private PopupData advancedTutorialUnlockedPopupData;

	[SerializeField]
	private PopupData advancedTutorialUnlockDeclinedPopupData;

	[SerializeField]
	private Act originSeasonAct;

	[SerializeField]
	private PopupData originSeasonUnlockedPopupData;

	[SerializeField]
	private PopupData originSeasonUnlockDeclinedPopupData;

	[SerializeField]
	private PopupData dailyEventsLockedPopupData;

	[SerializeField]
	private PopupData dailyEventsUnlockedPopupData;

	[SerializeField]
	private PopupData dailyEventsUnlockDeclinedPopupData;

	[SerializeField]
	private PopupData prizeFightsLockedPopupData;

	[SerializeField]
	private PopupData prizeFightsUnlockedPopupData;

	[SerializeField]
	private PopupData prizeFightsUnlockDeclinedPopupData;

	[SerializeField]
	private PopupData chatLockedPopupData;

	[SerializeField]
	private PopupData chatUnlockedPopupData;

	[SerializeField]
	private PopupData socialLockedPopupData;

	[SerializeField]
	private PopupData socialUnlockedPopupData;

	[SerializeField]
	private PopupData riftBattlesLockedPopupData;

	[SerializeField]
	private PopupData riftBattlesNotEnoughFightersPopupData;

	[SerializeField]
	private PopupData riftBattlesUnlockedPopupData;

	[SerializeField]
	private PopupData riftBattlesUnlockDecliendPopup;

	[SerializeField]
	private PopupData syncPvpLockedPopupData;

	[SerializeField]
	private PopupData syncPvpUnlockedPopupData;

	[SerializeField]
	private PopupData syncPvpUnlockDeclinedPopupData;

	[SerializeField]
	private Act appReviewAct;

	[SerializeField]
	private PopupData matchChallengesUnlockedPopupData;

	[SerializeField]
	private PopupData deploymentsLockedPopupData;

	[SerializeField]
	private PopupData deploymentsUnlockedPopupData;

	[SerializeField]
	private PopupData achievementsLockedPopupData;

	[SerializeField]
	private PopupData achievementsUnlockedPopupData;

	[SerializeField]
	private PopupData fightAssistLockedPopupData;

	[SerializeField]
	private PopupData fightAssistUnlockedPopupData;

	[SerializeField]
	private PopupData fightAssistUnlockedAcceptedPopupData;

	[SerializeField]
	private PopupData fightAssistUnlockedDeclinedPopupData;

	private bool advancedTutorialWasUnlocked;

	private int lastPlayerLevel;

	private bool werePrizeFightsUnlocked;

	private bool wereDailyEventsUnlocked;

	private bool wasOriginSeasonUnlocked;

	private bool wasChatUnlocked;

	private bool wasSocialUnlocked;

	private bool appReviewActWasComplete;

	private bool wereRiftBattlesUnlocked;

	private bool wasSyncPvpUnlocked;

	private bool forceUnlock;

	private bool wasChapterFullyCompleted;

	private bool wereDeploymentsUnlocked;

	private bool wereAchievementsUnlocked;

	private bool wasFightAssistUnlocked;

	private int cachedNumberOfFightersNeededForRiftBattles;

	private void Start()
	{
	}

	private void OnActiveSceneChanged(Scene from, Scene to)
	{
	}

	public void ForceUnlock()
	{
	}

	public bool ShowAppReviewPopup()
	{
		return false;
	}

	public bool ShowAdvancedTutorialUnlock()
	{
		return false;
	}

	public void ShowOriginSeasonUnlock(Action letsGoCallback)
	{
	}

	public Act GetFirstOriginAct()
	{
		return null;
	}

	public bool AreDailyEventsLocked()
	{
		return false;
	}

	public void ShowDailyEventsLocked()
	{
	}

	public void ShowDailyEventsUnlock(Action letsGoCallback)
	{
	}

	public bool ArePrizeFightsLocked()
	{
		return false;
	}

	public void ShowPrizeFightsLocked()
	{
	}

	public void ShowPrizeFightsUnlock(Action letsGoCallback)
	{
	}

	public bool AreRiftBattlesLocked()
	{
		return false;
	}

	public void ShowRiftBattlesLocked()
	{
	}

	public void ShowRiftBattlesUnlock(Action letsGoCallback)
	{
	}

	public bool HasEnoughFightersForRiftBattles()
	{
		return false;
	}

	public void ShowRiftBattlesInsufficientFighters()
	{
	}

	public bool IsChatLocked()
	{
		return false;
	}

	public void ShowChatLockedPopup()
	{
	}

	public void ShowChatUnlock()
	{
	}

	public bool IsSocialLocked()
	{
		return false;
	}

	public void ShowSocialLockedPopup()
	{
	}

	public void ShowSocialUnlock()
	{
	}

	public bool IsSyncPvpLocked()
	{
		return false;
	}

	public void ShowSyncPvpLocked()
	{
	}

	public void ShowSyncPvpUnlock(Action letsGoCallback)
	{
	}

	public void ShowMatchChallengesUnlock(Act act, Chapter chapter)
	{
	}

	public bool IsDeploymentsLocked()
	{
		return false;
	}

	public void ShowDeploymentsLockedPopup()
	{
	}

	public void ShowDeploymentsUnlock()
	{
	}

	public void ShowAchievmentsLockedPopup()
	{
	}

	public bool AreAchievementsLocked()
	{
		return false;
	}

	public void ShowAchievementsUnlock()
	{
	}

	public void ShowFightAssistLockedPopup()
	{
	}

	public bool IsFightAssistLocked()
	{
		return false;
	}

	public void ShowFightAssistUnlock()
	{
	}

	public bool IsGearLoadoutsLocked()
	{
		return false;
	}

	public void ShowGearLoadoutsUnlockIfNeeded()
	{
	}

	public bool CheckIfDestinationIsLocked(ChallengeRedirectDestination destination)
	{
		return false;
	}

	private void OnCampaignActsRefreshed()
	{
	}

	private void OnProfileUpdated(Profile profile)
	{
	}

	private void OnActCompleted(object act)
	{
	}

	private void OnChapterFullyCompleted(object passed)
	{
	}
}
