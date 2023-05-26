using System;
using System.Collections.Generic;
using UnityEngine;

public class Act : GameContentData, IServerUploadable
{
	public enum Difficulty
	{
		Undefined = -1,
		Basic = 0,
		Advanced = 1,
		Expert = 2,
		Master = 3
	}

	[SerializeField]
	private GameContentDisplayData actSelectContent;

	[SerializeField]
	private Season season;

	[SerializeField]
	private GameType gameType;

	[SerializeField]
	private Difficulty difficulty;

	[SerializeField]
	private BaseCharacterData baseCharacter;

	[SerializeField]
	private List<Loot> completionLoots;

	[SerializeField]
	private List<Loot> fullCompletionLoots;

	[SerializeField]
	public List<Chapter> chapters;

	[SerializeField]
	private List<DynamicResource> chapterResources;

	[SerializeField]
	private Act completedActRequirement;

	[SerializeField]
	private Act percentageActCompletedRequirement;

	[SerializeField]
	private float percentageCompletedRequirement;

	[SerializeField]
	private int playerLevelRequirement;

	[SerializeField]
	private bool sendChatActivityOnCompletion;

	public ScriptedSequence tutorial;

	[NonSerialized]
	private ScriptedSequence activeTutorial;

	private ActServerData actServerData;

	[NonSerialized]
	private List<Chapter> loadedChapters;

	public override Act GetAct()
	{
		return null;
	}

	public override GameContentDisplayData GetDisplayData()
	{
		return null;
	}

	public override string GetLockedText(string overrideTitle = null)
	{
		return null;
	}

	public override GameType GetGameType()
	{
		return default(GameType);
	}

	public override bool IsAvailable()
	{
		return false;
	}

	public override bool IsUnlocked()
	{
		return false;
	}

	public override float GetCompletionRatio()
	{
		return 0f;
	}

	public override void ResetCompletion()
	{
	}

	public List<Chapter> LoadChapters()
	{
		return null;
	}

	public void UnloadChapters()
	{
	}

	public List<Chapter> GetChapters()
	{
		return null;
	}

	public string GetTitle(bool localized = true)
	{
		return null;
	}

	public Difficulty GetDifficulty()
	{
		return default(Difficulty);
	}

	public int GetNumCompletedMatchChallenges()
	{
		return 0;
	}

	public int GetTotalNumMatchChallenges()
	{
		return 0;
	}

	public int GetNumCompletedMCPreLoad()
	{
		return 0;
	}

	public int GetTotalNumMCPreLoad()
	{
		return 0;
	}

	public bool IsCompleted()
	{
		return false;
	}

	public bool IsFullyCompleted()
	{
		return false;
	}

	public bool AnyMatchChallengesAvailable()
	{
		return false;
	}

	public void StartTutorial()
	{
	}

	public Chapter GetChapterByGuid(string chapterGuid)
	{
		return null;
	}

	public int GetPlayerLevelUnlockRequirement()
	{
		return 0;
	}

	public List<Loot> GetCompletionLoots()
	{
		return null;
	}

	public List<Loot> GetFullCompletionLoots()
	{
		return null;
	}

	public override Season GetSeason()
	{
		return default(Season);
	}

	public override bool ShouldBadge()
	{
		return false;
	}

	public override void ClearBadge()
	{
	}

	public bool ShouldSendChatActivityMessageOnCompletion()
	{
		return false;
	}

	public void UpdateFromActServerData(ActServerData actServerData)
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
}
