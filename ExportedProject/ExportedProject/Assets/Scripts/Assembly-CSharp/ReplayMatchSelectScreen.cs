using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReplayMatchSelectScreen : MonoBehaviour
{
	[SerializeField]
	private FightReplayView replaySelectItemPrototype;

	[SerializeField]
	private FightReplayView serverReplaySelectItemPrototype;

	[SerializeField]
	private InputField replaySearchField;

	[SerializeField]
	private GameObject localDownloadedReplayDividerGO;

	[SerializeField]
	private GameObject userServerReplayDividerGO;

	private List<FightReplayView> replayItems;

	private List<Toggle> toggles;

	private List<string> replayPaths;

	private void Awake()
	{
	}

	public void UGUI_FightButtonPressed()
	{
	}

	public void UGUI_SaveLastReplayPressed()
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

	private void RefreshReplayList()
	{
	}

	private void DownloadAndPlayReplay(string replayId)
	{
	}

	private void DestroyReplayItems()
	{
	}

	private string GetSelectedReplay()
	{
		return null;
	}
}
