using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReplaySelectScreen : MonoBehaviour
{
	[SerializeField]
	private FightReplayView itemPrototype;

	[SerializeField]
	private InputField replaySearchField;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private ToggleGroupRowController sectionToggleController;

	[SerializeField]
	private Toggle userListToggle;

	[SerializeField]
	private Toggle globalListToggle;

	[SerializeField]
	private Toggle savedListToggle;

	[SerializeField]
	private GameObject noFightHistoryGO;

	private int itemCounter;

	private List<FightReplayView> items;

	private List<string> replayPaths;

	private void Awake()
	{
	}

	public void UGUI_SearchReplayButtonPressed()
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

	private void DownloadAndPlayReplay(string replayId)
	{
	}

	private void OnSectionToggleActivated(Toggle toggle)
	{
	}

	private void PopulateFromServerReplays(string userPublicId = null)
	{
	}

	private void PopulateFromReplayServerDatas(List<FightReplayServerData> fightReplayServerDatas)
	{
	}

	private void PopulateFromSavedReplays()
	{
	}

	private void DestroyItems()
	{
	}

	private void HideItems()
	{
	}

	private FightReplayView GetItem()
	{
		return null;
	}

	private void OnShareReplayPressed(FightReplayServerData serverData)
	{
	}
}
