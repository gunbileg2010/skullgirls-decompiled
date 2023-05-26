using System;
using System.Collections.Generic;

public class GetEventsRequest : NetworkRequest
{
	public enum EventsFilter
	{
		None = 0,
		LimitedTimeActs = 1,
		RankedPlay = 2,
		LeaderboardEvent = 3
	}

	private EventsFilter eventsFilter;

	private List<LTAEventServerData> activeLimitedTimeActEvents;

	private List<EventServerData> activeLeaderboardEvents;

	private List<EventServerData> activeRiftBattleEvents;

	private List<EventServerData> activeSyncPvpEvents;

	private List<LTAEventServerData> futureLTAEvents;

	public GetEventsRequest(EventsFilter eventsFilter = EventsFilter.None)
	{
	}

	public override void Send(Action callback)
	{
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

	public List<LTAEventServerData> GetUpcomingLimitedTimeActEvents()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}

	private void ProcessEventsList(List<object> eventsList, List<LTAEventServerData> ltaEvents, List<EventServerData> leaderboardEvents = null, List<EventServerData> riftBattleEvents = null, List<EventServerData> syncPvpEvents = null)
	{
	}
}
