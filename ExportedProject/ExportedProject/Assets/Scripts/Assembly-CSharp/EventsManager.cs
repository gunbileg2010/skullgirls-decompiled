using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EventsManager : MonoBehaviour
{
	[SerializeField]
	private List<EventSet> eventSets;

	[SerializeField]
	public List<LTAEventData> ltaEvents;

	[SerializeField]
	private List<LeaderboardEventData> leaderboardEvents;

	[SerializeField]
	private SGMatch leaderboardEventMatch;

	[SerializeField]
	private List<RiftBattleEventData> riftBattleEvents;

	[SerializeField]
	private List<SyncPvpEventData> syncPvpEvents;

	[SerializeField]
	private SGMatch syncMatch;

	[SerializeField]
	private float changeLTATimerColorAtSeconds;

	private const int kEventCheckIntervalMinutes = 10;

	private const string kEventsSeenTimestampKey = "eventsSeenTimestamp";

	private const string kLeaderboardEventsSeenTimestampKey = "lbEventsSeenTimestamp";

	private const string kRiftBattleEventsSeenTimestampKey = "labBattleEventsSeenTimestamp";

	private const string kSyncPvpEventsSeenTimestampKey = "syncPvpEventsSeenTimestamp";

	private List<LTAEventServerData> activeLimitedTimeActEvents;

	private List<EventServerData> activeLeaderboardEvents;

	private List<EventServerData> activeRiftBattleEvents;

	private List<EventServerData> activeSyncPvpEvents;

	private List<LTAEventServerData> upcomingLimitedTimeActEvents;

	private List<EventServerData> allActiveAndUpcomingEvents;

	private DateTime nextEventCheckTime;

	private EventServerData currentEvent;

	private bool ltaActProgressUpdateRequired;

	public event Action EventsUpdated
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action FreeTicketsClaimed
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Start()
	{
	}

	public EventSet GetEventSetForEvent(EventData eventData)
	{
		return null;
	}

	public List<RiftBattleEventData> GetRiftBattleEvents()
	{
		return null;
	}

	public List<SyncPvpEventData> GetSyncPvpEvents()
	{
		return null;
	}

	public float GetTimeToChangeLTATimerColor()
	{
		return 0f;
	}

	public bool GetIsCurrentEventCompetitiveSyncPvp()
	{
		return false;
	}

	public EventData GetEventDataByGuid(string guid)
	{
		return null;
	}

	public void RefreshEventsFromServer(Action<bool, NetworkRequest> finishCallback, bool fetchActProgress = false)
	{
	}

	public List<LTAEventData> GetLTAEvents()
	{
		return null;
	}

	public List<LeaderboardEventData> GetLeaderboardEvents()
	{
		return null;
	}

	public SGMatch GetLeaderboardEventMatch()
	{
		return null;
	}

	public SGMatch GetSyncPvpEventMatch()
	{
		return null;
	}

	public List<LTAEventServerData> GetActiveLimitedTimeActEvents()
	{
		return null;
	}

	public List<EventServerData> GetActiveLeaderboardEvents()
	{
		return null;
	}

	public List<EventServerData> GetActiveRiftBattleEvents()
	{
		return null;
	}

	public List<EventServerData> GetActiveSyncPvpEvents()
	{
		return null;
	}

	public List<LTAEventServerData> GetFutureLTAEvents()
	{
		return null;
	}

	public DateTime? GetSoonestExpirationTime(EventDataType eventFilter = EventDataType.None)
	{
		return null;
	}

	public int GetUnseenEventsCount(EventDataType eventType = EventDataType.None)
	{
		return 0;
	}

	public int GetTotalUnclaimedFightHistoryCount(EventDataType eventType = EventDataType.None)
	{
		return 0;
	}

	public void MarkEventsSeen(EventDataType eventType)
	{
	}

	public EventServerData GetCurrentEvent()
	{
		return null;
	}

	public void SetCurrentEvent(EventServerData inEvent)
	{
	}

	public EventServerData GetEventServerDataWithId(string id)
	{
		return null;
	}

	public EventServerData GetEventServerDataWithGuid(string guid)
	{
		return null;
	}

	public void EnterEvent(string eventInstanceId, Action<bool> callback)
	{
	}

	public void UpdateCachedEventWithResultData(EventResultsServerData results)
	{
	}

	public void ClearAllDefenseTeamsContainingCharacters(List<Character> characters)
	{
	}

	public void InvalidateCachedData()
	{
	}

	public void ClaimDailyEventTickets()
	{
	}

	public void ClaimFreeRiftTickets()
	{
	}

	public void SkipEvent(LTAEventData ltaEventData, Action<bool> callback = null)
	{
	}

	public void RefreshEventLockedCharacterIds(Dictionary<string, List<string>> lockedCharacterMap)
	{
	}

	private void OnLoggedIn(AuthenticateRequest authRequest)
	{
	}

	private void EnterLTAEvent(LTAEventData ltaEventData, Action<bool> callback)
	{
	}

	private void ActualEnterEvent(string eventInstanceId, Action<bool> callback)
	{
	}

	private void HandleSkipEventRewards(List<RewardServerData> rewardServerDatas, LTAEventServerData ltaEventServerData, Action callback = null)
	{
	}

	private void ShowNotEnoughDailyEventTicketsPopup()
	{
	}

	private bool AreEventsInvalid()
	{
		return false;
	}

	private void RefreshLTAActProgress(Action<bool, NetworkRequest> finishCallback, bool checkValidEvents = false)
	{
	}

	private void ClaimFreeEventTicketsForCurrencyType(CurrencyType currencyType, string maxTicketsPopupHeaderLocKey, string maxTicketsPopupLocKey, string ticketsClaimedPopupHeaderLocKey, string ticketsClaimedPopupLocKey, Action<bool> callback = null, Action rewardPopupDismissalCallback = null)
	{
	}
}
