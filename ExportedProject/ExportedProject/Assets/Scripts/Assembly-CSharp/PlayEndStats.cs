using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PlayEndStats
{
	public class SkillStats
	{
		public string skillUsed
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Character skillCharacter
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int useCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}
	}

	private struct TagSkillComboBridge
	{
		public uint[] tags;

		public string skillValue;

		public TagSkillComboBridge(string skillValue, params uint[] tags)
		{
		}
	}

	public SGMatch match;

	public int playerTeamFighterScore;

	public int enemyTeamFighterScore;

	public List<Character> charactersUsed;

	public DateTime? startTime;

	public DateTime? endTime;

	public int playerLevelStart;

	public int playerLevelEnd;

	public WinState matchResult;

	public int hardCurrencyGained;

	public int softCurrencyGained;

	public int totalXpGained;

	public bool wasInitialPlay;

	public bool hasNotCompletedYet;

	public bool causedChapterFullyComplete;

	public bool usedAutoplay;

	public bool timedOut;

	public int averagePing;

	public bool disconnected;

	public int desyncFrame;

	public bool usedRelayServers;

	public bool usedCellularNetwork;

	public List<SkillStats> usedSkills;

	public byte matchChallengesResults;

	private uint lightAttack1;

	private uint lightAttack2;

	private uint lightAttack3;

	private uint heavyAttack1;

	private uint heavyAttack2;

	private uint tripAttack;

	private uint chargeAttack;

	private uint backDash;

	private uint launcher;

	private uint juggleAttack;

	private uint attack;

	private uint blocking;

	private TagSkillComboBridge[] _skillTagDictionary;

	public int playTimeSeconds => 0;

	private TagSkillComboBridge[] skillTagDictionary => null;

	public void Clear()
	{
	}

	public void UsedAutoPlay(bool usedAutoplay)
	{
	}

	public void ProcessNewActorStateMetrics(Actor actor)
	{
	}

	public void UsedSkill(Character character, string skill)
	{
	}

	public void UsedGear(Gear gear)
	{
	}

	public bool CompletedMatchChallenge(int matchChallengesIndex)
	{
		return false;
	}
}
