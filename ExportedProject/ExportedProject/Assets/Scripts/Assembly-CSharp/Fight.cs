using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Fight : ScriptableObject, IServerUploadable
{
	public Stage stage;

	public StageSet randomStages;

	[SerializeField]
	private int difficulty;

	[SerializeField]
	private AIProfile overrideEnemyAIProfile;

	public int playerMaxTeamSize;

	public int overrideDurationInSeconds;

	public int xpOverride;

	public float xpMultiplier;

	public float rewardMultiplier;

	public bool skipFightIntro;

	public bool skipXP;

	public int energyRequirement;

	public FightConstraint[] fightConstraints;

	public FightConstraint[] defenseTeamConstraints;

	public List<MatchChallengeData> matchChallenges;

	[SerializeField]
	private List<DynamicResource> enemyFightModifiers;

	public float enemyFighterFSMultiplierAddition;

	public List<CharacterGenerator> enemyCharacterGenerators;

	[SerializeField]
	private List<DynamicResource> playerFightModifiers;

	[SerializeField]
	private bool useCollectionForPlayerCharacters;

	[SerializeField]
	private List<CharacterGenerator> playerCharacterGenerators;

	public ScriptedSequence tutorial;

	public Fixed startingPositionOffset;

	public int fightSeed;

	[NonSerialized]
	private List<CollectibleNodeModifier> nodeModifiers;

	[NonSerialized]
	private List<Character> enemyCharacters;

	[NonSerialized]
	private List<Character> playerCharacters;

	public Stage GetStage(bool reroll = false)
	{
		return null;
	}

	public void GetPlayerCharactersIds(Action<List<string>> callback)
	{
	}

	public void SetPlayerCharacters(IList<Character> players)
	{
	}

	public void GetPlayerCharacters(Action<List<Character>> callback)
	{
	}

	public void ClearPlayerCharacters()
	{
	}

	public void SetEnemyCharacters(IList<Character> enemies)
	{
	}

	public List<Character> GetEnemyCharacters()
	{
		return null;
	}

	public void ClearEnemyCharacters()
	{
	}

	public void GenerateEnemyCharactersOnClient()
	{
	}

	public void GetUniqueBaseCharacterListForFight(Action<List<BaseCharacterData>> callback)
	{
	}

	public AIProfile GetEnemyAIProfile()
	{
		return null;
	}

	public FightConstraint[] GetFightConstraints()
	{
		return null;
	}

	public FightConstraint[] GetDefenseTeamConstraints()
	{
		return null;
	}

	public bool IsCharacterExcluded(Character character)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public int GetDifficulty()
	{
		return 0;
	}

	public void SetDifficulty(int difficulty)
	{
	}

	public int GetFightDurationSeconds()
	{
		return 0;
	}

	public bool HasModifiers()
	{
		return false;
	}

	public bool HasCollectibleNodeModifiers()
	{
		return false;
	}

	public bool HasConstraints()
	{
		return false;
	}

	public List<DynamicResource> GetFightModifiersForTeam(TeamType teamType)
	{
		return null;
	}

	public void SetFightModifiersForTeam(TeamType teamType, List<DynamicResource> fightModifiers)
	{
	}

	public List<SignatureAbility> TakeFightModifiersForTeam(TeamType teamType)
	{
		return null;
	}

	public void ReturnFightModifiersForTeam(TeamType teamType)
	{
	}

	public List<CollectibleNodeModifier> GetNodeModifiers()
	{
		return null;
	}

	public void SetNodeModifiers(List<CollectibleNodeModifier> collectibleNodeModifiers)
	{
	}

	public void SetEnemyFSMultiplierAddition(float value)
	{
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	private List<Character> GenerateCharacters(List<CharacterGenerator> characterGenerators, bool useCollection, Dictionary<string, List<Gear>> gearCollection = null, List<Character> characterCollection = null)
	{
		return null;
	}
}
