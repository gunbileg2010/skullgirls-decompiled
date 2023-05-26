using System;
using System.Collections.Generic;

public class UserServerData
{
	public string userId;

	public string publicUserId;

	public string handle;

	public float level;

	public long experience;

	public int tutorialProgress;

	public Dictionary<TutorialType, int> tutorialProgressMap;

	public int completedTutorials;

	public Dictionary<RarityTier, int> gachaShards;

	public string[] teamIds;

	public string[] competitiveTeamGuids;

	public List<string> tags;

	public Dictionary<string, GachaCountServerData> gachas;

	public CharacterServerData[] characters;

	public ConsumableServerData[] consumables;

	public string repCharacterId;

	public Character repCharacter;

	public GearServerData[] gear;

	public CollectibleNodeModifierServerData[] nodeModifiers;

	public Dictionary<string, object> hardCurrencyBalance;

	public Dictionary<string, object> softCurrencyBalance;

	public Dictionary<string, int> skillPoints;

	public Dictionary<string, VariantsEverOwnedServerData> variantsEverOwned;

	public Dictionary<RarityTier, int> keys;

	public Dictionary<Element, int> essenceShards;

	public Dictionary<Element, int> essences;

	public int characterGachaShards;

	public Dictionary<string, object> competitiveEquippedMoves;

	public List<AccountServerData> accountBindings;

	public int battleCurrencyBalance;

	public int battleTicketPaidBalance;

	public int battleTicketFreeBalance;

	public long freeBattleTicketRefreshDate;

	public int energyRefillBalance;

	public long dailyEventTicketRefreshDate;

	public int dailyEventTicketBalance;

	public Dictionary<string, int> rerollRunes;

	public int universalRerollRunesBalance;

	public int socialGiftStandardBalance;

	public int socialGiftGoldBalance;

	public int socialGiftStandardToOpenBalance;

	public int socialGiftGoldToOpenBalance;

	public long removeFriendsDailyTimestampReset;

	public int numberOfFriendsRemoved;

	public int numberOfAdsWatchedToday;

	public long adsResetDate;

	public int tier;

	public int gearCollectionCapacity;

	public int characterCollectionCapacity;

	public int nodeModifierCollectionCapacity;

	public int gearCollectionCount;

	public int characterCollectionCount;

	public int nodeModifierCollectionCount;

	public bool newChallengesAvailable;

	public int claimedEgretPointCount;

	public int claimableChallengeCount;

	public int claimableChallengeRewardThresholdCount;

	public DateTime challengeExpirationDate;

	public Dictionary<string, List<string>> eventLockedCharacterIdMap;

	public UserServerData()
	{
	}

	public UserServerData(Dictionary<string, object> dataDict)
	{
	}

	public void ParseData(Dictionary<string, object> dataDict)
	{
	}

	public void UpdateConsumableCollection(Dictionary<string, ConsumableServerData> consumableCollection)
	{
	}
}
