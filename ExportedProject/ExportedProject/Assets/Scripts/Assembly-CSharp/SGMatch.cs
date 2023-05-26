using System;
using System.Collections.Generic;
using UnityEngine;

public class SGMatch : GuidScriptableObject, IServerUploadable
{
	public StoryDialogPopupData dialoguePopupData;

	public bool isCompletionNode;

	public bool skipMatchPreview;

	public MatchType matchType;

	public List<Loot> completionLoot;

	public List<LootTable.WeightedLoot> randomDropLoots;

	public Fight[] fights;

	[SerializeField]
	private bool alwaysDisplayAsCompleted;

	[SerializeField]
	private bool allowReplay;

	[NonSerialized]
	private bool isCompleted;

	[NonSerialized]
	private bool isUnlocked;

	[NonSerialized]
	private byte matchChallengesProgress;

	private MatchServerData matchServerData;

	public void SetComplete(bool completed)
	{
	}

	public bool IsCompleted()
	{
		return false;
	}

	public void Unlock()
	{
	}

	public void Lock()
	{
	}

	public bool IsUnlocked()
	{
		return false;
	}

	public bool CanReplay()
	{
		return false;
	}

	public MatchType GetMatchType()
	{
		return default(MatchType);
	}

	public bool HasMatchChallenges()
	{
		return false;
	}

	public void AddMatchChallengesProgress(byte progress)
	{
	}

	public bool IsMatchChallengeComplete(int challengeIndex)
	{
		return false;
	}

	public Fight GetFight()
	{
		return null;
	}

	public FightServerData GetBasicFightData()
	{
		return null;
	}

	public void UpdateFromMatchServerData(MatchServerData matchServerData)
	{
	}

	public int GetEnemyCount()
	{
		return 0;
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	public override bool HasIssues()
	{
		return false;
	}
}
