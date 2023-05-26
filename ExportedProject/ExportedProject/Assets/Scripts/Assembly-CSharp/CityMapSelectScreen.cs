using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityMapSelectScreen : MonoBehaviour
{
	[SerializeField]
	private PopupData zoneLockedPopupData;

	[SerializeField]
	private GameObject actInfoGO;

	[SerializeField]
	private LocalizedUGUIText actTitleText;

	[SerializeField]
	private LocalizedUGUIText difficultyText;

	[SerializeField]
	private string tutorialActTitle;

	[SerializeField]
	private GameObject matchChallengesParentGO;

	[SerializeField]
	private LocalizedUGUIText completedChallengesText;

	[SerializeField]
	private LocalizedUGUIText totalChallengesText;

	[SerializeField]
	private float actInfoGOInitialHeight;

	[SerializeField]
	private float actInfoGOAdjustedHeight;

	[SerializeField]
	private GameObject unlockButtonGO;

	private Act act;

	private List<CityMapZone> mapZones;

	private const string kChapterLocKey = "ChapterSelect_Chapter";

	private bool debugUnlockAll;

	private void Awake()
	{
	}

	public void UGUI_DEBUGUnlockAllZones()
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

	private void OnZoneClicked(CityMapZone cityMapZone, int chapterIndex)
	{
	}

	private void EnterChapterByIndex(int chapterIndex)
	{
	}

	private void EnterChapter(Chapter chapter)
	{
	}

	private void RefreshMapZoneStatesFromAct()
	{
	}
}
