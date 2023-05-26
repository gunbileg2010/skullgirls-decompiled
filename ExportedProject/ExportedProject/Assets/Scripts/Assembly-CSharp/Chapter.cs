using System;
using System.Collections.Generic;
using UnityEngine;

public class Chapter : GuidScriptableObject, IServerUploadable
{
	public Zone zone;

	public NodeMap mapPrefab;

	[ReorderableList]
	public SGMatch[] matches;

	[SerializeField]
	private List<Loot> completionLoots;

	[SerializeField]
	private List<Loot> fullCompletionLoots;

	[SerializeField]
	private StoryDialogPopupData introStoryPopupData;

	[SerializeField]
	private bool playIntroOnlyIfNoProgress;

	[SerializeField]
	private StoryDialogPopupData outroStoryPopupData;

	private ChapterServerData chapterServerData;

	public float GetCompletionRatio()
	{
		return 0f;
	}

	public bool IsCompleted()
	{
		return false;
	}

	public bool IsFullyCompleted()
	{
		return false;
	}

	public int GetNumCompletedMatchChallenges()
	{
		return 0;
	}

	public int GetTotalNumMatchChallenges()
	{
		return 0;
	}

	public bool HasMatchChallenges()
	{
		return false;
	}

	public void ShowIntroPopup(Action<IPopup> callback = null)
	{
	}

	public void ShowOutroPopup(Action<IPopup> callback = null)
	{
	}

	public List<Loot> GetCompletionLoots(bool includeFinalMatchLoot = true)
	{
		return null;
	}

	public List<Loot> GetFullCompletionLoots()
	{
		return null;
	}

	public SGMatch GetMatchByGuid(string matchGuid)
	{
		return null;
	}

	public void UpdateFromChapterServerData(ChapterServerData chapterServerData)
	{
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	public override bool HasIssues()
	{
		return false;
	}

	private void ShowStoryPopup(StoryDialogPopupData storyPopupData, Action<IPopup> callback)
	{
	}
}
