using System;
using System.Collections;
using UnityEngine;

public class MatchManager : MonoBehaviour
{
	[SerializeField]
	private SGMatch friendVersusMatch;

	private Act currentAct;

	private Chapter currentChapter;

	private SGMatch currentMatch;

	[SerializeField]
	private float loadToFightSceneMinTime;

	[SerializeField]
	private float loadToFrontEndMinTime;

	private FightController currentFightController;

	private GameType gameType;

	private bool fightInProgress;

	private bool wasMatchAlreadyCompleted;

	private bool wasChapterAlreadyFullyCompleted;

	private bool wasActAlreadyFullyCompleted;

	private bool useReplays;

	private NetworkRequest lastFightEndRequest;

	private bool fightEndRequestSucceeded;

	private bool finishedEndFightNetworkCalls;

	private FightResultServerData fightResultServerData;

	private Character goToCharacterDetailsCharacter;

	private bool wantToUpgradeCharacter;

	private bool goToTeamSelect;

	private bool goToLogin;

	private IAPStoreContext? goToStoreWithContext;

	private PlayEndStats playEndStatsTracker;

	private FightInstanceServerData currentFightServerData;

	private FightReplay activeFightReplay;

	public Act CurrentAct
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Chapter CurrentChapter
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SGMatch CurrentMatch
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void PrepFight(Action<PrepFightRequest> callback)
	{
	}

	public void PrepVersusFight(string opponentId, bool isLineId, Action<PrepFightRequest> callback)
	{
	}

	public void SetCurrentFightServerData(FightInstanceServerData fightInstanceServerData)
	{
	}

	public FightInstanceServerData GetCurrentFightServerData()
	{
		return null;
	}

	public void StartFight(Fight fight, bool isRetry = false, string sceneName = "1xFight", bool quickly = false)
	{
	}

	public bool StartReplay(string replayFileName, bool quickly = false)
	{
		return false;
	}

	public FightReplay GetActiveFightReplay()
	{
		return null;
	}

	public void RestartFight()
	{
	}

	public void EndFight(string goToStateOverride = null)
	{
	}

	public IEnumerator SendEndFightNetworkRequests(Fight fight, WinState winState, FightStats fightStats)
	{
		return null;
	}

	public FightResultServerData GetLatestFightResultServerData()
	{
		return null;
	}

	public bool IsEndFightNetworkCallFinished()
	{
		return false;
	}

	public bool DidFightEndRequestSucceed()
	{
		return false;
	}

	public NetworkRequest GetLastFightEndNetworkRequest()
	{
		return null;
	}

	public FightController GetCurrentFightController()
	{
		return null;
	}

	public bool IsFightInProgress()
	{
		return false;
	}

	public void SetGameType(GameType newGameType)
	{
	}

	public GameType GetGameType()
	{
		return default(GameType);
	}

	public bool ShouldUseReplaysForCurrentFight()
	{
		return false;
	}

	public void SetGoToCharacterDetailsCharacter(Character character, bool wantToUpgrade = false)
	{
	}

	public void SetGoToTeamSelect()
	{
	}

	public void SetGoToLogin()
	{
	}

	public void SetGoToStoreWithContext(IAPStoreContext? context)
	{
	}

	public SGMatch GetVersusMatch()
	{
		return null;
	}

	public PlayEndStats GetPlayEndStatsTracker()
	{
		return null;
	}

	public void StopAndReportPlayMetrics()
	{
	}

	public void UpdateLocalCharacterEnergyForFight(Fight fight, Action callback = null)
	{
	}

	public bool ShouldStartXPBoostTutorial()
	{
		return false;
	}

	private IEnumerator DoStartFight(Fight fight, string sceneName, bool quickly)
	{
		return null;
	}

	private void ClearMatchAndGoToState(string state, bool clearChapterToContinue = false, bool clearActToContinue = false)
	{
	}

	private void Cleanup()
	{
	}

	private IEnumerator DoReturnToFrontend()
	{
		return null;
	}

	private void StartRecordingFightMetrics(bool isReplay, Action callback = null)
	{
	}

	private void ConstructAndSendActCompletionActivityMessage()
	{
	}

	private void ConstructAndSendHighStreakActivityMessage()
	{
	}

	private void FinishStartFightRequest(StartFightRequest startFightRequest, bool startFromFrontend, ref bool waitingForServerCall, ref bool serverCallSucceeded)
	{
	}
}
