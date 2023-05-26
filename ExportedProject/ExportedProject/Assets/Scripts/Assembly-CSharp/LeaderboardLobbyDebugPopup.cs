using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardLobbyDebugPopup : MonoBehaviour
{
	[SerializeField]
	private InputField setStreakInput;

	private LeaderboardEventData leaderboardEventData;

	private EventServerData eventServerData;

	private Action<List<FightInstanceServerData>, int> onChangedCallback;

	public void Show(LeaderboardEventData leaderboardEventData, EventServerData eventServerData, Action<List<FightInstanceServerData>, int> onChangedCallback)
	{
	}

	public void Hide()
	{
	}

	public void UGUI_SetStreak()
	{
	}
}
