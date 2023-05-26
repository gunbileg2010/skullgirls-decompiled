using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActSelectScreen : MonoBehaviour
{
	[SerializeField]
	private GameObject seasonSelectGO;

	[SerializeField]
	private ToggleGroupRowController seasonToggleController;

	[SerializeField]
	private Toggle mainSeasonToggle;

	[SerializeField]
	private Toggle originSeasonToggle;

	[SerializeField]
	private Badge mainSeasonBadge;

	[SerializeField]
	private Badge originSeasonBadge;

	[SerializeField]
	private ScrollList scrollList;

	[SerializeField]
	private ActSelectItem actSelectItemPrefab;

	[SerializeField]
	private ScrollListItem comingSoonItemPrefab;

	[SerializeField]
	private FanfarePopupData actUnlockFanfarePopupData;

	[SerializeField]
	private Text noEventsText;

	[SerializeField]
	private TalkingHeadController characterImageController;

	[SerializeField]
	private ContextualTutorial ltaContextualTutorial;

	[SerializeField]
	private ContextualTutorial leaderboardContextualTutorial;

	private static GameContentData lastFocusedDataProvider;

	private static bool shouldHighlightNextAct;

	private GameType gameType;

	private Season selectedSeason;

	private List<GameContentData> actSelectDataProviders;

	private List<GameContentData> loadedActs;

	private List<ActSelectItem> actSelectItems;

	private ScrollListItem comingSoonScrollListItem;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public static void HighlightNextActOnNextVisit()
	{
	}

	public void PointAtAct(int actIndex, GameObject indicatorPrefab)
	{
	}

	public void UGUI_UnlockButtonPressed()
	{
	}

	private IEnumerator OnStateEntered(IGameState prevState, object context)
	{
		return null;
	}

	private IEnumerator OnStateExited(IGameState nextState)
	{
		return null;
	}

	private void SetupScreen(GameContentData pointAt, Action callback)
	{
	}

	private void GetAvailableActs(Action<bool> callback)
	{
	}

	private void OnStateEnteredContinue(GameContentData pointAt = null)
	{
	}

	private void SortActSelectData()
	{
	}

	private void ClearActs()
	{
	}

	private void Refresh(GameContentData context = null)
	{
	}

	private IEnumerator DoHighlightNextAct()
	{
		return null;
	}

	private GameContentData ChoosePointAtAct(GameContentData desired = null)
	{
		return null;
	}

	private void ShowUnlockPopups()
	{
	}

	private void OnSeasonToggleActivated(Toggle toggle)
	{
	}

	private void OnScrollListItemWillBeFocused(ScrollListItem item)
	{
	}

	private void OnActSelectItemTimerExpired(ActSelectItem expiredItem)
	{
	}

	private void OnDailyEventTicketsClaimed()
	{
	}
}
