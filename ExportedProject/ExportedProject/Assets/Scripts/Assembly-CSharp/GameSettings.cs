using System;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : ScriptableObject, IServerUploadable
{
	[Serializable]
	public class XpResetThreshold
	{
		public int level;

		public float baseLevelUpXpMultiplier;
	}

	[Serializable]
	public class RiftBattleRatingResetThreshold
	{
		public int requiredRating;

		public int ratingToResetTo;
	}

	[Serializable]
	public class StatCap
	{
		public StatType type;

		public float cap;
	}

	[Serializable]
	public class WinStreakModifierBase
	{
		public float scoreMultiplier;

		public List<DynamicResource> additionalPlayerMatchModifiers;

		public List<DynamicResource> additionalEnemyMatchModifiers;
	}

	[Serializable]
	public class WinStreakModifierRiftBattles : WinStreakModifierBase
	{
		public float displayHealthPercentGain;

		public float displayAttackPercentGain;
	}

	[Serializable]
	public class WinStreakModifierLeaderboards : WinStreakModifierBase
	{
		public float fsPercentMin;

		public float fsPercentMax;

		public int hardFightOffset;

		public int AILevel;

		public float enemyFSMultiplierAddition;
	}

	[Serializable]
	public class DupePenaltyModifierRiftBattles
	{
		public int requiredDupeCount;

		public DynamicResource dupePenalityModifier;
	}

	public float overallFighterScoreMultiplier;

	public float skillNodeFSGlobalMultiplier;

	public float enemyFighterFSGlobalMultiplier;

	public float superAbilityUnlockFSMultiplierAddition;

	public float superAbilityFSMultiplierAdditionPerLevel;

	public float prestigeAbilityUnlockFSMultiplierAddition;

	public float prestigeAbilityFSMultiplierPerLevel;

	public float prestigeAbilityMaxFSMultiplierAddition;

	[Space]
	public float sizableFighterScoreFractionGap;

	public float levelScaleForLifebar;

	public float levelScaleForAttack;

	[SerializeField]
	private int[] baseLevelUpXpPerTier;

	public float nextLevelXpMultiplier;

	[SerializeField]
	private float[] levelingMultiplierPerTier;

	public XpResetThreshold[] xpResetThresholds;

	public float xpGrantedOnLossFraction;

	public int maxXpGrantedOnLoss;

	public float replayRewardMultiplier;

	public float replayXpMultiplier;

	public float storyModeReplayXpMultiplier;

	public float teamXpMultiplier;

	public int baseLevelUpPlayerXp;

	public float nextLevelPlayerXpMultiplier;

	public float playerLevelingMultiplier;

	public XpResetThreshold[] playerXpResetThresholds;

	public int unlockChatAtLevel;

	public int unlockSocialAtLevel;

	public int unlockPrizeFightsAtLevel;

	public int unlockDailyEventsAtLevel;

	public int unlockSyncPvpAtLevel;

	public int unlockRiftBattlesAtLevel;

	public int unlockDeploymentsAtLevel;

	public int unlockAchievementsAtLevel;

	public int unlockFightAssistAtLevel;

	public int unlockGearLoadoutsAtLevel;

	public int[] prestigeAbilityLevelsPerTier;

	[SerializeField]
	private List<float> percentChanceForShinyPerRarityTier;

	public int maximumMonthsTimerDisplay;

	[SerializeField]
	public List<StatCap> statCaps;

	public bool specialsCooldownWhileTaggedOut;

	public float teamSuperbarGainOnPointGainMultiplier;

	public float tagInCooldown;

	public float assistCooldown;

	[SerializeField]
	private int energyCooldownSeconds;

	public Fixed critChance;

	public Fixed critDamageMultiplier;

	public int comboCounterResetFrameDelay;

	public float queuedInputTimeLimit;

	public AIProfile defaultEnemyAIProfile;

	public AIProfile defaultAutoplayAIProfile;

	public int hitpauseAdjustment;

	public int evadeHitpause;

	public Fixed chipDamageMultiplier;

	public Fixed redLifeMultiplier;

	public Fixed elementalAdvantageDamageMultiplier;

	public Fixed elementalDisadvantageDamageMultiplier;

	public bool showDetailedChevrons;

	public Fixed lightModifierMultiplier;

	public Fixed heavyModifierMultiplier;

	public Fixed armorPercent;

	public int armorMaxStack;

	public int barrierMaxStack;

	public Fixed barrierDamageBlockPercent;

	public Fixed bleedPercentHealth;

	public Fixed bleedPercentAttack;

	public int bleedMaxStack;

	public int blessingMaxStack;

	public Fixed blessingHealPercent;

	public Fixed deathMarkBlockProficiencyPercentRemoval;

	public Fixed deathMarkCritDamagePercentIncrease;

	public Fixed enragePercent;

	public int enrageMaxStack;

	public int evasionMaxStack;

	public Fixed hastePercent;

	public int powerSurgeMaxStack;

	public Fixed powerSurgeDamagePercent;

	public int precisionMaxStack;

	public int autoBlockMaxStack;

	public Fixed autoBlockActivationChance;

	public int guardBreakMaxStack;

	public Fixed guardBreakActivationChance;

	public Fixed regenPercent;

	public int regenMaxStack;

	public Fixed slowPercent;

	public int slowMaxStack;

	public int thornsMaxStack;

	public Fixed thornsReflectPercent;

	public int miasmaMaxStack;

	public Fixed miasmaDrainPercent;

	public Fixed witherPercent;

	public int witherMaxStack;

	public Fixed slimeDamagePercent;

	public int slimeMaxStack;

	public int fatigueStunDuration;

	public int fightDurationInSeconds;

	[SerializeField]
	private int[] damageIconsAmountPerTier;

	public Fixed guardMeterRegenPerFrame;

	public Fixed chargeAttackGuardMeterDamage;

	public Fixed guardMeterMaxValue;

	public Fixed guardMeterDamageFactor;

	public Fixed guardMeterBlockbusterDamageFactor;

	public int guardMeterLockoutLengthFrames;

	public int guardCrushExtraHitstop;

	public int wakeupThrowInvincibilityFrames;

	public Fixed competitiveSuperDamageMultipier;

	public Fixed competitiveSpecialDamageMultiplier;

	public Fixed competitiveSekhmetDamageMultiplier;

	public SkillTree aiSkillTree;

	public List<WinStreakModifierLeaderboards> leaderboardEventWinStreakModifiers;

	public TargetFighterScoreList defaultTargetFighterScores;

	public int defenseHistoryFightCap;

	public float leaderboardDefenderWinScoreMultiplier;

	public float leaderboardDefenderLossScoreMultiplier;

	public int leaderboardDefenseBonusFightThreshold;

	public float leaderboardDefenseBonusMultiplierPerFight;

	public float leaderboardDefenseBonusMaxMultiplier;

	public List<int> highWinStreakCheckpoints;

	public float leaderboardMatchmakingRangeReductionFactor;

	[SerializeField]
	private int riftBattleMaxCharacterUseCount;

	[SerializeField]
	private int riftBattleHistoryFightCap;

	[SerializeField]
	private int riftBattleBaseCoinsForBattleRewardWin;

	[SerializeField]
	private int riftBattleAttemptsCount;

	[SerializeField]
	private int riftBattleScoreDivisorForBattleReward;

	[SerializeField]
	private int riftBattleBaseCoinsForBattleRewardLoss;

	[SerializeField]
	private int riftBattleEloKFactor;

	[SerializeField]
	private float riftBattleMatchmakingLoosening;

	[SerializeField]
	private float riftBattleMatchmakingUpperBound;

	[SerializeField]
	private int riftBattleMatchmakingProtectionInitialLevelSpread;

	[SerializeField]
	private int riftBattleMatchmakingProtectionLevelSpreadPerWin;

	[SerializeField]
	private int riftBattleWinStreakHourDuration;

	public float riftBattleDefenseOpponentLossMultiplier;

	public float riftBattleDefenseOpponentWinMultiplier;

	public float riftBattleRevengePlayerWinMultiplier;

	public float riftBattleRevengePlayerLossMultiplier;

	public float riftBattleRevengeOpponentWinMultiplier;

	public float riftBattleRevengeOpponentLossMultiplier;

	[SerializeField]
	private List<DupePenaltyModifierRiftBattles> riftBattleDupePenalityModifiers;

	[SerializeField]
	private List<WinStreakModifierRiftBattles> riftBattleWinStreakModifiers;

	[SerializeField]
	private List<RiftBattleRatingResetThreshold> riftBattleRatingResetThresholds;

	[SerializeField]
	private int riftBattleFightWinPoints;

	[SerializeField]
	private float riftBattleFightPointsHealthMultiplier;

	[SerializeField]
	private int riftBattleFightPointsPerSecondRemaining;

	[SerializeField]
	private int riftBattleFightPointsForNoDeaths;

	[SerializeField]
	private int riftBattleFightPointsForBlockbusterFinish;

	[SerializeField]
	private int riftBattleFightComboPointsPerHit;

	[SerializeField]
	private int riftBattleFightComboPointsMaxHits;

	[SerializeField]
	private int riftBattleEndNoLossesBonus;

	[SerializeField]
	private int riftBattleEndAttackerDiversityBonus;

	public int leaderboardMatchmakingDBTimeoutMs;

	public int riftBattleMatchmakingDBTimeoutMs;

	public float matchmakingHttpRequestTimeoutSeconds;

	public float syncPvpMatchmakingFSPercentageRange;

	public long syncPvpMatchmakingBacklistTimeInSeconds;

	public int[] syncPvpPingLimitOptions;

	public int syncPvpPingLimitDefaultIndex;

	public int syncPvpFrameDelayMin;

	public int syncPvpFrameDelayMax;

	public int syncPvpFrameDelayDefault;

	[SerializeField]
	private bool chatEnabled;

	public List<ChatChannelGroup> chatChannelGroups;

	[SerializeField]
	private int chatIdealChannelOccupancy;

	[SerializeField]
	private int chatMaxChannelOccupancy;

	[SerializeField]
	private int reportCountForChatBan;

	[SerializeField]
	private float reportPeriodNumOfDays;

	[SerializeField]
	private float chatBanNumOfDays;

	public int maxNumLoadouts;

	public int GetBaseLevelUpXpByTier(RarityTier tier)
	{
		return 0;
	}

	public float GetLevelingMultiplierByTier(RarityTier tier)
	{
		return 0f;
	}

	public int GetDamageIconsByTier(RarityTier tier)
	{
		return 0;
	}

	public int GetPrestigeAbilityLevelsForTier(RarityTier tier)
	{
		return 0;
	}

	public int GetEnergyCooldownSeconds()
	{
		return 0;
	}

	public Fixed GetModifierStrengthMultiplier(ModifierStrength strength)
	{
		return default(Fixed);
	}

	public ElementStatus GetElementAdvantageOrDisadvantage(Element myElement, Element theirElement)
	{
		return default(ElementStatus);
	}

	public int GetRiftBattleMaxCharacterUseCount()
	{
		return 0;
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	public float GetStatCapForStatType(StatType type)
	{
		return 0f;
	}

	public DupePenaltyModifierRiftBattles GetDupePenaltyModifierRiftBattles(int dupeCount)
	{
		return null;
	}

	public WinStreakModifierBase GetWinStreakModifierForStreak(EventDataType eventDataType, int winStreak)
	{
		return null;
	}

	public float GetScoreMultiplierForWinStreak(EventDataType eventDataType, int winStreak)
	{
		return 0f;
	}

	public int GetWinStreakModifierCount(EventDataType eventDataType)
	{
		return 0;
	}

	public long GetRiftBattleWinStreakHourDuration()
	{
		return 0L;
	}

	public int GetRiftBattleAttemptsCount()
	{
		return 0;
	}

	public void ApplySyncPvpPrefightDataUpdate(SyncPvpPrefightServerData data)
	{
	}

	public void ApplyRiftBattleStateDataUpdate(Dictionary<string, object> dataDict)
	{
	}

	public void GetRiftBattlePointInfo(out int pointsForVictory, out int pointsForHealth, out int pointsForTime, out int pointsForNoDeaths, out int pointsForBBEnd, out int pointsPerComboHit, out int maxComboHits, out int pointsForNoLosses, out int pointsForAttackerDiversity)
	{
		pointsForVictory = default(int);
		pointsForHealth = default(int);
		pointsForTime = default(int);
		pointsForNoDeaths = default(int);
		pointsForBBEnd = default(int);
		pointsPerComboHit = default(int);
		maxComboHits = default(int);
		pointsForNoLosses = default(int);
		pointsForAttackerDiversity = default(int);
	}
}
