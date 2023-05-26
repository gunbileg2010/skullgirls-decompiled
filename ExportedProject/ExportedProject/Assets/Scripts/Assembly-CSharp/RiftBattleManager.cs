using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RiftBattleManager : MonoBehaviour
{
	public int riftBattleStartMenuHistoryCount;

	private const string kRiftBattleEndDate = "riftBattleEndDate";

	private BattleMapServerData originalUserMap;

	private BattleMapServerData currentUserMap;

	private bool isDefenseMapDirty;

	private Challenge riftBattleChallengeUpdate;

	private RiftBattleStateServerData currentBattleState;

	private Dictionary<string, int> defenderVariantCounts;

	private Dictionary<string, int> defenderIdsAndLocations;

	public event Action onDefenderVariantCountsUpdated
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Start()
	{
	}

	public RiftBattleStateStatus GetBattleStateStatus()
	{
		return default(RiftBattleStateStatus);
	}

	public RiftBattleStateServerData GetBattleState()
	{
		return null;
	}

	public string GetOpponentName()
	{
		return null;
	}

	public bool IsBattleInProgress()
	{
		return false;
	}

	public bool IsAttackerDiversityJeopardized(List<Character> characters)
	{
		return false;
	}

	public bool IsAttackerDiversityJeopardizedByCharacter(Character character, List<Character> team)
	{
		return false;
	}

	public bool DoesUserMapLackDefenderDiversity()
	{
		return false;
	}

	public bool IsDefenderDiversityJeopardized(List<Character> team)
	{
		return false;
	}

	public bool IsDefenderDiversityJeopardizedByCharacter(Character character, List<Character> team)
	{
		return false;
	}

	public void GetSeasonEndTimerInfo(out DateTime endDate, out string labelLocKey)
	{
		endDate = default(DateTime);
		labelLocKey = null;
	}

	public HashSet<string> GetDupeDefenderVariantGuids()
	{
		return null;
	}

	public void RecordVisitForCurrentSeason()
	{
	}

	public bool DidSeasonEndSinceLastVisit()
	{
		return false;
	}

	public void RefreshBattleStateFromServer(Action<NetworkRequest> callback)
	{
	}

	public void StartRiftBattle(string battleInstanceId, bool usePaidTicket, Action<NetworkRequest> callback)
	{
	}

	public void RequestOpponentRefresh(bool useHC, Action<NetworkRequest> callback)
	{
	}

	public SGMatch GetBossMatch(BattleInstanceServerData battleInstance)
	{
		return null;
	}

	public void ProcessFinishedBattleInstance(BattleInstanceServerData battleInstance, EventServerData eventData)
	{
	}

	public void ResetRiftBattleHistoryBadgeNumber()
	{
	}

	public int GetStartMenuBadgingNumber()
	{
		return 0;
	}

	public void LogRiftBattleAttackerDiversityMetric(Action callback = null)
	{
	}

	public void UpdateDefenderDiversity(List<Character> oldDefenders, List<Character> newDefenders, Fight updatedFight, int nodeIndex)
	{
	}

	public void RefreshUserMap(Dictionary<int, MapNodeProgressServerData> opponentProgress)
	{
	}

	public void RefreshOpponentMap(BattleMapServerData opponentMap, Dictionary<int, MapNodeProgressServerData> userProgress)
	{
	}

	private void RefreshMapMatches(SGMatch[] matches, BattleMapServerData map, Dictionary<int, MapNodeProgressServerData> mapProgress, bool useSnapshots, bool applyWinStreak = false)
	{
	}

	public List<string> GetTeamIdsForNode(int nodeIndex)
	{
		return null;
	}

	public void SetTeamIdsForNode(int nodeIndex, List<string> teamIds, Action callback = null)
	{
	}

	public List<string> GetModifierIdsForNode(int nodeIndex)
	{
		return null;
	}

	public void SetModifierIdsForNode(int nodeIndex, List<string> modifierIds)
	{
	}

	public bool DoTeamMembersExistOnOtherNode(List<string> teamIds, int currentNodeIndex)
	{
		return false;
	}

	public void RemoveModifiersFromMap(List<string> modifierIds)
	{
	}

	public bool DoNodeModifiersExistOnOtherNode(List<string> nodeModifierIds, int currentNodeIndex)
	{
		return false;
	}

	public int GetNodeIndexForMatch(string eventGuid, string matchGuid)
	{
		return 0;
	}

	public bool IsDefenseMapFullyFilledOut()
	{
		return false;
	}

	public bool IsDefenseMapPartiallyFilledOut()
	{
		return false;
	}

	public bool IsDefenseMapDirty()
	{
		return false;
	}

	public void SaveDefenseMap(Action<bool> callback)
	{
	}

	public void DiscardDefenseMapChanges(Action callback = null)
	{
	}

	public RiftBattleEventData GetRiftBattleEventData()
	{
		return null;
	}

	public void GetRevengeBattleInstanceFromServer(BattleInstanceServerData sourceBattleInstance, Action<GetBattleInstanceRequest> requestCallback)
	{
	}

	public bool CanCharacterBeUsedInThisBattle(Character character)
	{
		return false;
	}

	public int GetCharacterUseCountInBattle(Character character)
	{
		return 0;
	}

	public Challenge GetUpdatedRiftBattleChallenge()
	{
		return null;
	}

	public void CheckEnergyAndShowPopups(Fight currentFight, Action<bool> callback, Action<IPopup> teamSelectCallback, Action<IPopup> cancelCallback)
	{
	}

	private void SaveBattleState(RiftBattleStateServerData newBattleState, Action callback = null)
	{
	}

	private void RemoveCharactersFromOtherMapNodes(List<string> characterIds, int currentMapNodeIndex)
	{
	}

	private void RemoveModifiersFromAllMapNodes(List<string> modifierIds)
	{
	}

	private void RemoveModifiersFromOtherMapNodes(List<string> modifierIds, int currentNodeIndex)
	{
	}

	private void SetModifiersInUse(List<string> modifierIds, bool isInUse)
	{
	}

	private void RefreshMatchAndStreakModifiers(SGMatch[] matches, GameSettings.WinStreakModifierBase winStreakMod = null, Func<Fight, List<Character>> potentialNewCharactersCallback = null)
	{
	}

	private void LockUnlockMapCharactersForEvent(BattleMapServerData mapServerData, bool lockIn, Action callback = null)
	{
	}

	private void OnStateChanged(string fromState, string toState)
	{
	}

	private void OnChallengesUpdated()
	{
	}

	private int GetTotalDupeDefenderCount()
	{
		return 0;
	}
}
