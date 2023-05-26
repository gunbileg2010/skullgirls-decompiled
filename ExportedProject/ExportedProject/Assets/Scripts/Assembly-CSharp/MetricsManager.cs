using System;
using System.Collections.Generic;
using UnityEngine;
using com.adjust.sdk;

public class MetricsManager : MonoBehaviour
{
	public const string kRememberFightCount = "metFightCount";

	public const string kRememberWasLaunchedBefore = "metLaunchedAppBefore";

	public const string kRememberInitialRiftBattleDefenderDiversity = "metRiftBattleDefenderDiversity";

	[SerializeField]
	private Adjust adjustPrefab;

	[SerializeField]
	private bool logWarningsToMetrics;

	[SerializeField]
	private bool logErrorToMetrics;

	[SerializeField]
	private bool debug;

	public const bool kUseFirebase = true;

	internal const string PLAYERPREFS_USER_ID_SAVEKEY = "SGM_MM_ID";

	private static bool firebaseAnalyticsAvailable;

	private const string kStashLogTimestampSaveKey = "LastStashEventSent";

	private Dictionary<string, string> stashSPKeyToBaseCharGuidMap;

	private Dictionary<string, string> stashRRKeyToBaseCharGuidMap;

	internal const int kMinutesBeforeSessionTimeout = 5;

	private string sessionId;

	private DateTime sessionPausedTimestamp;

	private const int kAdjustEventFtueStep = 8;

	private const string kAdjustEventFTUEGacha1Guid = "0";

	private const string kAdjustEventFTUEGacha2Guid = "13";

	private const string kAdjustEventCalendarGuid = "d616abbb-6444-44b0-89b2-9f779d7e91d3";

	private const string kAdjustEventAct2Match1Guid = "99b0e83f-3e75-49aa-93a4-19a4d63af846";

	private const string kAdjustEventAct3Match1Guid = "ad650907-e0ed-4478-ab66-b4f17d14f9a1";

	private const int kAdjustEventLevelUpLevel = 4;

	private const string kAdjustEventTokenAccountBindNew = "y4jto6";

	private const string kAdjustEventTokenAccountBindExisting = "p1b7xo";

	private const string kAdjustEventTokenCompleteFTUE = "8613a5";

	private const string kAdjustEventTokenGachaOpen = "3em2vv";

	private const string kAdjustEventTokenCalendarDay0 = "j2ldup";

	private const string kAdjustEventTokenCalendarDay1 = "nja372";

	private const string kAdjustEventTokenCalendarDay2 = "aaqswf";

	private const string kAdjustEventTokenCalendarDay3 = "bzz6eq";

	private const string kAdjustEventTokenCalendarDay4 = "vtn7kq";

	private const string kAdjustEventTokenCalendarDay5 = "lwuiff";

	private const string kAdjustEventTokenCalendarDay6 = "byix4u";

	private const string kAdjustEventTokenStartAct2 = "94lwug";

	private const string kAdjustEventTokenStartAct3 = "x7mivl";

	private const string kAdjustEventTokenUpgradeMove = "1clsah";

	private const string kAdjustEventTokenEquipMove = "5467w0";

	private const string kAdjustEventTokenPlayerLevelUp = "bqon9c";

	private const string kAdjustEventTokenBuySkillTreeNode = "uue6jc";

	private const string kAdjustEventTokenSpendHC = "1rh3rg";

	private const string kAdjustEventTokenIAPPurchase = "p7shvh";

	public string MetricsID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	public bool DebugEnabled()
	{
		return false;
	}

	public static void OnFirebaseAvailable()
	{
	}

	public static bool IsFirebaseAvailable()
	{
		return false;
	}

	public void LogLogin(bool newUser, bool autoLogin)
	{
	}

	public void LogAppLaunch()
	{
	}

	public void LogAccountBinding(LoginType provider, bool onCreateNewUser)
	{
	}

	public void LogFTUELanguagePicked()
	{
	}

	public void LogAgreedToToS()
	{
	}

	public void LogTutorialProgress(TutorialType tutorialType, int stepNumber, string stepGUID = null)
	{
	}

	public string GetTutorialTypeMetricString(TutorialType tutorialType)
	{
		return null;
	}

	public void LogRiftBattleTutorialBegin()
	{
	}

	public void LogRiftBattleTutorialEnd()
	{
	}

	public void LogStashStatus(bool force = false)
	{
	}

	public void LogMoneyStoreOfferPurchase(PurchaseData purchaseData, string currencyCode, double priceDollarsCents, List<Reward> rewards)
	{
	}

	public void LogLimitedTimeOfferPurchase(PurchaseData purchaseData, string currencyCode, double priceDollarCents, List<Reward> rewards)
	{
	}

	public void LogCurrencyStoreOfferPurchase(CurrencyPurchaseAction purchaseAction, OfferLoots offerLoots)
	{
	}

	public void LogRewardedAdView(List<Reward> rewards, string adRewardGuid)
	{
	}

	public void LogDeploymentGains(List<RewardServerData> rewardServerData, string deploymentGuid, Action callback = null)
	{
	}

	public void LogGachaPurchase(GachaData gacha, int count, CurrencyType currencyType, int currencyPaid, bool upsell = false, RarityTier priceTierContext = RarityTier.Silver)
	{
	}

	public void LogGachaPurchaseWithVoucher(GachaData gacha, int denominationIndex, int count)
	{
	}

	public void LogFriendRequest(FriendRequestActionRequest.FriendAction action)
	{
	}

	public void LogSendSocialGift(CurrencyType currency)
	{
	}

	public void LogConsumableConsumed(ConsumableData data, int amountConsumed = 1)
	{
	}

	public void LogTutorialXPBoostsReceived(ConsumableData data, int amountReceived)
	{
	}

	public void LogTutorialXPBoostsConsumed(ConsumableData data, int amountConsumed)
	{
	}

	public void LogSocialGiftOpen(List<Reward> rewards)
	{
	}

	public void LogAtSocialGiftCap()
	{
	}

	public void LogGachaOpen(GachaData gacha, List<Reward> rewards)
	{
	}

	public void LogEnergyRefillPurchase(EnergyType type, int charactersRefilledCount, int hardCurrencyPaid, int energyRefillsPaid)
	{
	}

	public void LogLeaderboardFightRefreshPurchase(int currencyPaid)
	{
	}

	public void LogLeaderboardFightRestoreStreakPurchase(int currencyPaid, int streakRestored)
	{
	}

	public void LogDirectPurchaseStoreSink(CurrencyType currencyType, int currencyPaid, string sinkGuid, BaseCharacterData baseCharacter = null)
	{
	}

	public void LogHardCurrencyLTOPurchase(CurrencyType currencyType, int currencyPaid, string guid, List<Reward> rewards)
	{
	}

	public void LogInventoryExpansionPurchased(CollectionType collectionType, Price expansionCost)
	{
	}

	public void LogDailyEventTicketSink(string eventGuid, int amount, string context)
	{
	}

	public void LogChallengeGoNowClicked(Challenge challenge)
	{
	}

	public void LogChallengeClaim(Challenge challenge)
	{
	}

	public void LogChallengeCompleted(Challenge challenge)
	{
	}

	public void LogChallengesRewardsClaimed(int thresholdValue, List<Reward> rewards)
	{
	}

	public void LogChallengeClaimAllClicked()
	{
	}

	public void LogMailOpen(MailServerData mail)
	{
	}

	public void LogMailClaim(MailServerData mail, List<Reward> rewards)
	{
	}

	public void LogMailUrlClick(MailServerData mail)
	{
	}

	public void LogMailInternalClicked(MailServerData mail)
	{
	}

	public void LogRewardCalendarClaim(RewardCalendar calendar, int day)
	{
	}

	public void LogFreeEventTicketClaim(List<Reward> rewards, CurrencyType currencyType)
	{
	}

	public void LogRiftBattleTicketPurchase(int hardCurrencyPaid)
	{
	}

	public void LogCampaignFightEvent(bool fightEnd, Act act, Chapter chapter, SGMatch match, int userFighterScore, int opponentFighterScore, PlayEndStats playEndStats = null, bool userWon = false, int fightLengthSeconds = 0, float averageFps = 0f)
	{
	}

	public void LogLimitedTimeActFightEvent(bool fightEnd, Act act, Chapter chapter, SGMatch match, int userFighterScore, int opponentFighterScore, PlayEndStats playEndStats = null, bool userWon = false, int fightLengthSeconds = 0, float averageFps = 0f)
	{
	}

	public void LogPrizeFightFightEvent(bool fightEnd, EventServerData eventData, SGMatch match, int userFighterScore, int opponentFighterScore, PlayEndStats playEndStats = null, bool userWon = false, int fightLengthSeconds = 0, float averageFps = 0f)
	{
	}

	public void LogPrizeFightPointsGain(EventServerData eventData, long gainedPFPoints, string context)
	{
	}

	public void LogRiftBattleFightEvent(bool fightEnd, Chapter chapter, SGMatch match, EventServerData eventData, int userFighterScore, int opponentFighterScore, PlayEndStats playEndStats = null, bool userWon = false, int fightLengthSeconds = 0, float averageFps = 0f)
	{
	}

	public void LogSyncPvpFightEvent(bool fightEnd, EventServerData eventData, int userFighterScore, int opponentFighterScore, PlayEndStats playEndStats = null, bool userWon = false, int fightLengthSeconds = 0, float averageFps = 0f)
	{
	}

	public void LogOfflineFightEvent(bool fightEnd, string fightGUID, int userFighterScore, int opponentFighterScore, bool userWon = false, int fightLengthSeconds = 0, float averageFps = 0f)
	{
	}

	public void LogCampaignFightGains(Act act, Chapter chapter, SGMatch match, FightResultServerData fightResultData, PlayEndStats playEndStats)
	{
	}

	public void LogLimitedTimeActFightGains(Act act, Chapter chapter, SGMatch match, FightResultServerData fightResultData, PlayEndStats playEndStats)
	{
	}

	public void LogPrizeFightFightGains(EventServerData eventData, FightResultServerData fightResultData, PlayEndStats playEndStats)
	{
	}

	public void LogRiftBattleFightGains(EventServerData eventData, FightResultServerData fightResultData, PlayEndStats playEndStats)
	{
	}

	public void LogSyncPvpFightGains(EventServerData eventData, FightResultServerData fightResultData, PlayEndStats playEndStats)
	{
	}

	public void LogChatSent(int channel, string channelName)
	{
	}

	public void LogChatActivitySent(int channel, string channelName)
	{
	}

	public void LogChatChannelChanged(int channel, string channelName)
	{
	}

	public void LogRiftBattleDefenseCharactersUsed(string guid, List<Character> characters)
	{
	}

	public void LogRiftBattleStart(int userRating, BattleInstanceServerData battleInstance, XsProfile xsProfile, EventServerData eventServerData, bool usePaidTicket)
	{
	}

	public void LogRiftBattleAttackerDiversity(string eventGuid, bool hasAttackerDiversity)
	{
	}

	public void LogRiftBattleDefenderDiversity(string eventGuid, int dupeDefenderCount, bool tryingToDoInitialLogging = false)
	{
	}

	public void LogRiftBattleEnd(BattleInstanceServerData battleInstance, EventServerData eventServerData, List<Reward> rewards)
	{
	}

	public void LogRiftOpponentsRefreshPurchase(int currencyPaid)
	{
	}

	public void LogSyncPvpMatchmakingStart(string guid, bool isPrivateMatch)
	{
	}

	public void LogSyncPvpMatchmakingSucceed(string guid, bool isPrivateMatch, int ping, int failureCount, int durationSeconds)
	{
	}

	public void LogSyncPvpmatchmakingFailed(string guid, bool isPrivateMatch, int ping, string errorCode, int failureCount, int durationSeconds)
	{
	}

	public void LogSyncPvpMatchmakingCanceled(string guid, bool isPrivateMatch, int failureCount, int durationSeconds)
	{
	}

	public void LogMoveUpgrade(Gear gear, int upgradeLevelCount, Currency upgradeCost, int newLevel, List<StatServerData> updatedStats)
	{
	}

	public void LogMoveSold(Gear gear, int coinsEarned)
	{
	}

	public void LogMoveEquipped(Gear gear, Character character)
	{
	}

	public void LogGearLoadoutEquipped(GearLoadout gearLoadout, Character character)
	{
	}

	public void LogGearLoadoutSaved(GearLoadout gearLoadout, Character character)
	{
	}

	public void LogMoveStatRerolled(Gear gear, CurrencyType currencyType, int amount, string statHumanReadableGuid)
	{
	}

	public void LogMoveStatRerollConfirmed(Gear gear, bool accepted)
	{
	}

	public void LogNodeModifierUpgrade(CollectibleNodeModifier collectibleNodeModifier, int upgradeLevelCount, Currency upgradeCost, int newLevel)
	{
	}

	public void LogNodeModifierSold(CollectibleNodeModifier collectibleNodeModifier, int coinsEarned)
	{
	}

	public void LogPlayerLevelUp(string reasonGuid, int level, List<Reward> rewards)
	{
	}

	public void LogCharacterLevelUp(Character character, int level, List<Reward> rewards, bool fromPowerUp = false)
	{
	}

	public void LogCharacterPowerUp(Character powerUpCharacter, List<Character> foodCharacters, long xpGained, int startLevel, int endLevel, int gainedSkillPoints, List<RewardServerData> rewards)
	{
	}

	public void LogCharacterEvolve(Character evolveCharacter, List<Character> foodCharacters, Price price, List<RewardServerData> rewards)
	{
	}

	public void LogPrestigeGained(Character character, string context, int previousPrestige, int currentPrestige)
	{
	}

	public void LogMaxTierCharacterConverted(Character characterToConvert, Element element)
	{
	}

	public void LogShinyTransfer(Character targetCharacter, Character sourceCharacter)
	{
	}

	public void LogRepCharacterSet(Character character)
	{
	}

	public void LogSkillTreeNodePurchase(Character character, SkillTreeNode node, bool usedHcShortcut, Currency coinPrice, Currency skillPointPrice, Currency gemPrice)
	{
	}

	public void LogSkillTreeGatePurchase(Character character, SkillTreeNode node, RarityTier tier, Currency keyPrice)
	{
	}

	public void LogMarqueeAvailable(Character character)
	{
	}

	public void LogMarqueeUnlock(Character character, int featureSet, Currency skillPointCost, Currency coinsCost)
	{
	}

	public void LogMarqueeUpgrade(Character character, int featureSet, int newLevel, Currency skillPointCost)
	{
	}

	public void LogMarqueeSwap(Character character, int newFeatureSet, int newLevel, Currency gemPrice)
	{
	}

	private void LogSkillTreePurchase(Character character, SkillTreeNode node, bool usedHcShortcut, bool isGate = false)
	{
	}

	private void LogMarqueeEvent(Character character, string marqueeEventType, int featureSet, int level)
	{
	}

	public void LogPlayerProfileView(bool isCurrentUser = false)
	{
	}

	public void LogPlayerDuel()
	{
	}

	public void LogPlayerOptionsView(string gameArea = null)
	{
	}

	public void LogSubmitUserReport(ReportType reportType, string reporterId, string reportedId, List<string> reasons)
	{
	}

	public void LogScreenView(string screenName, string context = null)
	{
	}

	public void LogGenericImpression(string guid, string context = null)
	{
	}

	public void LogGenericConversion(string guid, string context = null)
	{
	}

	public void LogDirectPurchaseImpression(DirectPurchaseStoreItem directPurchaseStoreItem)
	{
	}

	public void LogDirectPurchaseConversion(DirectPurchaseStoreItem directPurchaseStoreItem)
	{
	}

	public void LogCharacterUsed(Character character, string gameMode, string eventGuid, bool won = false)
	{
	}

	public void LogIDFADecision(bool consented)
	{
	}

	public void LogAttributionChanged(AdjustAttribution attribution)
	{
	}

	public void LogAchievementCompleted(Achievement achievement)
	{
	}

	public void LogAchievementClaimed(Achievement achievement, List<Reward> rewards)
	{
	}

	public void LogDeploymentStarted(DeploymentServerData deployment, Character[] characters)
	{
	}

	public void LogDeploymentRefreshed(DeploymentServerData deployment)
	{
	}

	public void LogDeploymentCompleted(DeploymentServerData deployment)
	{
	}

	public void LogDeploymentHurriedUp(DeploymentServerData deployment)
	{
	}

	private void LogDeploymentAction(DeploymentServerData deployment, string deploymentAction, Character[] usedCharacters = null)
	{
	}

	public void LogNotificationsDisabled()
	{
	}

	public void LogNotificationClicked(string notificationType)
	{
	}

	public void LogOfferViewed(OfferData offerData, string context = null)
	{
	}

	private void LogRealCurrencyTransaction(PurchaseData purchaseData, string currencyCode, double priceDollarsCents, string itemType, string cartType, List<Reward> rewardsGained)
	{
	}

	private void LogResourceSource(List<Reward> rewards, string sourceType, string sourceGuid, string gameMode = null)
	{
	}

	private void LogCurrencySource(string metricCurrencyName, string metricCurrencyType, int currencyAmount, string sourceType, string sourceGuid, string gameMode = null)
	{
	}

	private void LogItemSource(string itemGuid, string itemType, int count, string sourceType, string sourceGuid, bool shiny = false, string gameMode = null)
	{
	}

	private void LogCurrencySink(string metricCurrencyName, string metricCurrencyType, int currencyAmount, string sinkType, string sinkGuid, string gameMode = null, string context = null)
	{
	}

	private void LogItemSink(string itemGuid, string itemType, int count, string sourceType, string sourceGuid, bool shiny = false, string gameMode = null, int prestigeLevel = 0)
	{
	}

	private void LogEnergySinkSinglePlayer(int amount, string sinkGuid, string gameMode)
	{
	}

	private void LogEnergySinkMultiplayer(int amount, string sinkGuid, string gameMode)
	{
	}

	private void LogDirectPurchaseImpressionConversion(string eventName, DirectPurchaseStoreItem storeItem)
	{
	}

	private void LogOfferImpressionConversion(string eventString, string guid, string baseCharacterGUID, string variantCharacterGUID, string gearGUID, RarityTier rarityTier, int itemAmount, string itemName, string itemType, int virtualCurrencyAmount, string virtualCurrencyName, string virtualCurrenctyType, string context)
	{
	}

	private void LogFight(bool isFightEnd, string gameMode, string actGUID, string chapterGUID, string fightGUID, string eventGUID, string difficulty, int userFightScore, int opponentFightScore, int winStreak, PlayEndStats playEndStats, bool userWon = false, int fightLengthSeconds = 0, float averageFps = 0f)
	{
	}

	private void LogFightGains(string fightGuid, string gameMode, FightResultServerData fightResultData, PlayEndStats playEndStats)
	{
	}

	private void LogTutorialProgress(int stepNumber, string tutorialType, string stepGUID)
	{
	}

	private void LogChatEvent(int channel, string channelName, string chatType)
	{
	}

	private void SyncPvpMatchmakingEvent(string matchmakingEventType, string guid, bool isPrivateMatch, int ping, string errorCode, int failureCount, int durationSeconds)
	{
	}

	private string GetCharacterGuid(Character character)
	{
		return null;
	}

	private string GetCharacterGuid(VariantCharacterData characterData)
	{
		return null;
	}

	private string GetGearGuid(Gear gear)
	{
		return null;
	}

	private string GetGearGuid(GearData gearData)
	{
		return null;
	}

	private string GetCollectibleNodeModifierGuid(CollectibleNodeModifier collectibleNodeModifier)
	{
		return null;
	}

	private string GetCollectibleNodeModifierGuid(CollectibleNodeModifierData collectibleNodeModifierData)
	{
		return null;
	}

	private string GetChapterGuidBasedOnIndex(Act act, Chapter chapter)
	{
		return null;
	}

	private void IncrementFightCount(int increment = 0)
	{
	}

	private void AddDefaultEventParams(ref MetricEvent metricEvent)
	{
	}

	private void AddCatalogEventParams(ref MetricEvent metricEvent)
	{
	}

	private void OnLogMessageReceivedThreaded(string message, string stackTrace, LogType logType)
	{
	}

	private void OnLogMessageReceived(string message, string stackTrace, LogType logType)
	{
	}
}
