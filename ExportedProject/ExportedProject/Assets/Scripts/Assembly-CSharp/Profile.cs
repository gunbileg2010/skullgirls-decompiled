using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

[Serializable]
public class Profile : ISerializable
{
	public const int kMaxPlayerLevel = 70;

	private string internalId;

	private string publicId;

	private string playerHandle;

	private long playerExperience;

	private float playerLevel;

	private List<string> tags;

	private int unreadMailCount;

	private Dictionary<LoginType, AccountServerData> accountBindings;

	private string repCharacterId;

	private Character repCharacter;

	private Dictionary<string, List<GearLoadout>> gearLoadoutCollection;

	private Character[] teamMembers;

	private string[] initialTeamMemberIds;

	private Character[] competitiveTeamMembers;

	private CurrencyBalance hardCurrencyBalance;

	private CurrencyBalance softCurrencyBalance;

	private Dictionary<string, int> skillPointsPool;

	private Dictionary<string, VariantsEverOwnedServerData> variantsEverOwned;

	private Dictionary<string, GachaCountServerData> gachaInventory;

	private Dictionary<string, ConsumableServerData> consumableInventory;

	private Dictionary<RarityTier, int> keyInventory;

	private Dictionary<Element, int> essenceShardInventory;

	private Dictionary<Element, int> essenceInventory;

	private Dictionary<RarityTier, int> gachaShards;

	private int characterGachaShards;

	private int energyRefillBalance;

	private int cachedCollectionCount;

	private int cachedSpecialCollectionCount;

	private int cachedNodeModifierCollectionCount;

	private int gearCollectionCapacity;

	private int characterCollectionCapacity;

	private int nodeModifierCollectionCapacity;

	private int battleCurrencyBalance;

	private int battleTicketsPaid;

	private int battleTicketsFree;

	private DateTime freeBattleTicketRefreshTimestamp;

	private int dailyEventTickets;

	private DateTime dailyEventTicketRefreshTimestamp;

	private Dictionary<string, int> rerollRunesPool;

	private int universalRerollRunes;

	private int socialGiftStandardBalance;

	private int socialGiftGoldBalance;

	private int socialGiftStandardToOpenBalance;

	private int socialGiftGoldToOpenBalance;

	private DateTime removeFriendsDailyTimestampReset;

	private int numberOfFriendsRemoved;

	private int numberOfAdsWatchedToday;

	private DateTime adsResetDate;

	private RiftTier riftTier;

	private List<string> visitedScreens;

	private List<ToastManager.ToastData> scheduledToasts;

	private Collection collection;

	public Act PreviousAct
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

	public Chapter PreviousChapter
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

	public SGMatch PreviousMatch
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

	public Act ActToContinue
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

	public Chapter ChapterToContinue
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

	public SGMatch MatchToContinue
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

	public int catalogCompletionBronzeCount
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int catalogCompletionSilverCount
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int catalogCompletionGoldCount
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int catalogCompletionDiamondCount
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float catalogCompletionBronzePercent
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float catalogCompletionSilverPercent
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float catalogCompletionGoldPercent
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float catalogCompletionDiamondPercent
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int catalogCompletionTotalCount
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float catalogCompletionTotalPercent
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static event Action<int, int> CurrenciesChanged
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

	public static event Action<Profile> ProfileUpdated
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

	public Profile()
	{
	}

	protected Profile(SerializationInfo info, StreamingContext context)
	{
	}

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public string GetDisplayName(bool withPlaceholder = true)
	{
		return null;
	}

	public void SetHandle(string handle, bool needToPayForChange, Action<NetworkRequest> callback)
	{
	}

	public string GetInternalId()
	{
		return null;
	}

	public string GetPublicId()
	{
		return null;
	}

	public long GetPlayerExperience()
	{
		return 0L;
	}

	public int GetPlayerLevel()
	{
		return 0;
	}

	public float GetPlayerLevelProgress()
	{
		return 0f;
	}

	public float GetPlayerLevelWithProgress()
	{
		return 0f;
	}

	public bool IsDeveloper()
	{
		return false;
	}

	public bool HasTag(string tag)
	{
		return false;
	}

	public void AddTag(string tag)
	{
	}

	public void FetchCollectionIfMissing(Action callback = null)
	{
	}

	public bool HasCollectionBeenFetched()
	{
		return false;
	}

	public bool CanCharacterBeUsedInCompetitiveSyncPvp(Character character, List<Character> characterList)
	{
		return false;
	}

	public void CharacterCollectionHasDupes(Action<bool> callback)
	{
	}

	public void GetCharacterCollection(bool asCopy = false, Action<List<Character>> callback = null)
	{
	}

	public void GetCharacterFromCollection(string backendId, Action<Character> callback)
	{
	}

	public Character GetCharacterFromList(VariantCharacterData variantData, List<Character> characterList)
	{
		return null;
	}

	public Character GetCharacterFromList(string backendId, List<Character> characterList)
	{
		return null;
	}

	public void GetCharactersFromCollection(List<string> characterIds, bool includeNull = false, Action<List<Character>> callback = null)
	{
	}

	public void GetCompetitiveCharacterCollection(bool asCopy = false, Action<List<Character>> callback = null)
	{
	}

	public void GetCurrentCharacterCollection(bool asCopy = false, Action<List<Character>> callback = null)
	{
	}

	public void GetTopFightersByBaseCharacterGuid(Action<Dictionary<string, Character>> callback)
	{
	}

	public void SetTeamCharacters(Character[] newTeamCharacters, Action<NetworkRequest> callback = null)
	{
	}

	public void GetTeamCharacters(Action<List<Character>> callback)
	{
	}

	public int GetTeamSize()
	{
		return 0;
	}

	public List<string> GetTeamIds()
	{
		return null;
	}

	public void SetRepCharacter(Character character, Action<NetworkRequest> callback = null)
	{
	}

	public Character GetRepCharacter()
	{
		return null;
	}

	public void RemoveCharactersFromCollection(List<Character> characters)
	{
	}

	public int GetCharacterCollectionCapacity()
	{
		return 0;
	}

	public int GetCharacterCollectionCount()
	{
		return 0;
	}

	public void GetGear(GearData gearData, Action<Gear> callback)
	{
	}

	public void GetGear(string backendId, Action<Gear> callback)
	{
	}

	public void GetGearCollection(Action<Dictionary<string, List<Gear>>> callback)
	{
	}

	public int GetGearCollectionCapacity()
	{
		return 0;
	}

	public void GetGearCollectionList(Action<List<Gear>> callback)
	{
	}

	public int GetGearCount(Dictionary<string, List<Gear>> gearDict = null)
	{
		return 0;
	}

	public void GetGearFor(BaseCharacterData baseCharacter, Action<List<Gear>> callback)
	{
	}

	public Gear GetGearFromDict(GearData gearData, Dictionary<string, List<Gear>> gearDict)
	{
		return null;
	}

	public Gear GetGearFromDict(string backendId, Dictionary<string, List<Gear>> gearDict)
	{
		return null;
	}

	public void RemoveGearFromCollection(params Gear[] gears)
	{
	}

	public void GetGearLoadoutsFor(BaseCharacterData baseCharacter, Action<List<GearLoadout>> getLoadoutsCallback, Action<NetworkRequest> failureCallback = null)
	{
	}

	public void AddGearLoadout(BaseCharacterData baseCharacter, GearLoadout gearLoadout)
	{
	}

	public void GetNodeModifierCollection(bool asCopy = false, Action<List<CollectibleNodeModifier>> callback = null)
	{
	}

	public int GetNodeModifierCollectionCapacity()
	{
		return 0;
	}

	public void GetNodeModifierFromCollection(string backendId, Action<CollectibleNodeModifier> callback = null)
	{
	}

	public void GetNodeModifiersFromCollection(List<string> modifierIds, bool includeNull = false, Action<List<CollectibleNodeModifier>> callback = null)
	{
	}

	public List<CollectibleNodeModifier> GetNodeModifiersFromList(List<string> modifierIds, bool includeNull = false, List<CollectibleNodeModifier> nodeModifierList = null)
	{
		return null;
	}

	public void RemoveNodeModifiersFromCollection(params CollectibleNodeModifier[] nodeModifiers)
	{
	}

	public void RemovePrice(Price price)
	{
	}

	public void RemoveCurrency(Currency currency)
	{
	}

	public int GetSkillPoints(BaseCharacterData baseData)
	{
		return 0;
	}

	public int GetSkillPoints(string baseCharGuid)
	{
		return 0;
	}

	public void AddSkillPoints(BaseCharacterData baseData, int amount)
	{
	}

	public void RemoveSkillPoints(BaseCharacterData baseData, int amount)
	{
	}

	public int GetKeys(RarityTier tier)
	{
		return 0;
	}

	public void AddKeys(RarityTier tier, int amount)
	{
	}

	public void RemoveKeys(RarityTier tier, int amount)
	{
	}

	public CurrencyBalance GetSoftCurrencyBalance()
	{
		return null;
	}

	public int GetTotalSoftCurrency()
	{
		return 0;
	}

	public void AddSoftCurrency(CurrencyTier tier, int amount)
	{
	}

	public void RemoveSoftCurrency(int amount)
	{
	}

	public CurrencyBalance GetHardCurrencyBalance()
	{
		return null;
	}

	public int GetTotalHardCurrency()
	{
		return 0;
	}

	public void AddHardCurrency(CurrencyTier tier, int amount)
	{
	}

	public void RemoveHardCurrency(int amount)
	{
	}

	public int GetGachaShards(RarityTier tier)
	{
		return 0;
	}

	public void AddGachaShards(RarityTier tier, int amount)
	{
	}

	public void RemoveGachaShards(RarityTier tier, int amount)
	{
	}

	public int GetTotalCharacterGachaShards()
	{
		return 0;
	}

	public void AddCharacterGachaShards(int amount)
	{
	}

	public void RemoveCharacterGachaShards(int amount)
	{
	}

	public int GetEssenceShards(Element elementType)
	{
		return 0;
	}

	public void AddEssenceShardsWithRollover(Element elementType, int amount)
	{
	}

	public void AddEssenceShards(Element elementType, int amount)
	{
	}

	public void RemoveEssenceShards(Element elementType, int amount)
	{
	}

	public int GetEssences(Element elementType)
	{
		return 0;
	}

	public void AddEssences(Element elementType, int amount)
	{
	}

	public void RemoveEssences(Element elementType, int amount)
	{
	}

	public int GetTotalBattleCurrency()
	{
		return 0;
	}

	public void AddBattleCurrency(int amount)
	{
	}

	public void RemoveBattleCurrency(int amount)
	{
	}

	public int GetTotalBattleTicketsPaid()
	{
		return 0;
	}

	public int GetTotalBattleTicketsFree()
	{
		return 0;
	}

	public int GetTotalBattleTickets()
	{
		return 0;
	}

	public void RemoveBattleTicket(bool usePaidTicket)
	{
	}

	public void AddBattleTickets(CurrencyTier tier, int amount)
	{
	}

	public void SetBattleTickets(CurrencyTier tier, int amount)
	{
	}

	public DateTime GetFreeBattleTicketRefreshTimestamp()
	{
		return default(DateTime);
	}

	public void SetFreeEventTicketRefreshTimestamp(CurrencyType currencyType, DateTime value)
	{
	}

	public void ReadBattleTicketsFromBattleState(RiftBattleStateServerData battleState)
	{
	}

	public int GetTotalDailyEventTickets()
	{
		return 0;
	}

	public void AddDailyEventTickets(int amount)
	{
	}

	public void RemoveDailyEventTickets(int amount)
	{
	}

	public DateTime GetDailyEventTicketsRefreshTimestamp()
	{
		return default(DateTime);
	}

	public int GetRerollRunes(BaseCharacterData baseData)
	{
		return 0;
	}

	public int GetRerollRunes(string baseCharGuid)
	{
		return 0;
	}

	public void AddRerollRunes(BaseCharacterData baseData, int amount)
	{
	}

	public void RemoveRerollRunes(BaseCharacterData baseData, int amount)
	{
	}

	public int GetTotalUniversalRerollRunes()
	{
		return 0;
	}

	public void AddUniversalRerollRunes(int amount)
	{
	}

	public void RemoveUniversalRerollRunes(int amount)
	{
	}

	public void AddSocialGift(bool isGold, int amount)
	{
	}

	public void RemoveSocialGift(bool isGold, int amount)
	{
	}

	public int GetSocialGiftCount(bool isGold)
	{
		return 0;
	}

	public void AddEnergyRefill(int amount)
	{
	}

	public int GetEnergyRefillCount()
	{
		return 0;
	}

	public void RemoveEnergyRefillCurrency(int amount)
	{
	}

	public bool SentSocialGift()
	{
		return false;
	}

	public void ClaimedSocialGift(bool isGold)
	{
	}

	public int GetSocialGiftToOpenCount(bool isGold)
	{
		return 0;
	}

	public void OpenedSocialGifts()
	{
	}

	public bool GetIsAtAdCap()
	{
		return false;
	}

	public DateTime GetAdResetDate()
	{
		return default(DateTime);
	}

	public void SetAdsResetDate(long adsResetDate)
	{
	}

	public int GetNumberOfAdsWatchedToday()
	{
		return 0;
	}

	public void SetNumberOfAdsWatchedToday(int numberOfAdsWatchedToday)
	{
	}

	public Dictionary<string, GachaCountServerData> GetGachaInventory()
	{
		return null;
	}

	public void AddGacha(string gachaGuid, int amount)
	{
	}

	public int GetGachaCount(string gachaGuid)
	{
		return 0;
	}

	public int GetTotalGachasCount()
	{
		return 0;
	}

	public void SpendVoucher(string gachaGuid, int denominationIndex)
	{
	}

	public Dictionary<string, ConsumableServerData> GetConsumableInventory()
	{
		return null;
	}

	public void RemoveConsumable(string consumableGuid, int amount)
	{
	}

	public void AddConsumable(string consumableGuid, int amount)
	{
	}

	public ConsumableServerData GetConsumable(string consumableGuid)
	{
		return null;
	}

	public ConsumableServerData GetActiveConsumable(ConsumableType consumableType)
	{
		return null;
	}

	public void MarkNewConsumablesSeen()
	{
	}

	public int GetNumNewConsumables()
	{
		return 0;
	}

	public void GrantRewardsLocally(List<RewardServerData> rewards)
	{
	}

	public void GrantRewardsLocally(List<Reward> rewards)
	{
	}

	public void GrantRewardLocally(Reward reward)
	{
	}

	public void Refresh(Action<bool> callback = null, FullUserDataType depthFlags = FullUserDataType.All)
	{
	}

	public void RefreshAccountBindings(Action<bool> callback = null)
	{
	}

	public void UpdateFromUserServerData(UserServerData userData, bool isCurrentPlayer = true, FullUserDataType depthFlags = FullUserDataType.All)
	{
	}

	public void UpdatePlayerXpFromServerData(XpRewardServerData playerXpReward, Action callback = null)
	{
	}

	public void UpdateAccountBindings(List<AccountServerData> accountServerDatas)
	{
	}

	public void SetScheduledToasts(List<ToastManager.ToastData> scheduledToasts)
	{
	}

	public List<ToastManager.ToastData> GetScheduledToasts()
	{
		return null;
	}

	public void SetUnreadMailCount(int count)
	{
	}

	public int GetUnreadMailCount()
	{
		return 0;
	}

	public void DecrementUnreadMailCount()
	{
	}

	public bool IsFirstVisit(string stateName)
	{
		return false;
	}

	public void SetStateVisited(string stateName)
	{
	}

	public void ClearStatesVisited()
	{
	}

	public bool AtAnySoftCap()
	{
		return false;
	}

	public bool AtCharacterSoftCap()
	{
		return false;
	}

	public bool AtGearSoftCap()
	{
		return false;
	}

	public bool AtNodeModifierSoftCap()
	{
		return false;
	}

	public bool CanExpandCollectionCapacity(CollectionType inventoryType)
	{
		return false;
	}

	public void IncreaseCollectionCapacity(CollectionType collectionType)
	{
	}

	public AccountServerData GetAccountBinding(LoginType loginType)
	{
		return null;
	}

	public void AddAccountBinding(LoginType loginType, AccountServerData accountServerData)
	{
	}

	public void ResetCollectionNotifCount()
	{
	}

	public int GetCollectionNotifCount()
	{
		return 0;
	}

	public void ResetGearCollectionNotifCount()
	{
	}

	public int GetGearCollectionNotifCount()
	{
		return 0;
	}

	public void ResetNodeModifierCollectionNotifCount()
	{
	}

	public int GetNodeModifierCollectionNotifCount()
	{
		return 0;
	}

	public RiftTier GetRiftTier()
	{
		return default(RiftTier);
	}

	public void PartialUpdateFromBattleStateServerData(RiftBattleStateServerData data)
	{
	}

	public VariantsEverOwnedServerData.OwnedStatus GetIsVariantEverOwned(VariantCharacterData variant)
	{
		return default(VariantsEverOwnedServerData.OwnedStatus);
	}

	public void SetVariantEverOwned(VariantCharacterData variant, bool isShiny)
	{
	}

	private void SetVariantsOwnedForEachRarityTier(Dictionary<string, VariantsEverOwnedServerData> updatedVariantsOwned)
	{
	}

	private List<string> GetCharacterIds(Character[] characters)
	{
		return null;
	}

	private void UpdateTeamFromServerData(string[] teamIds, Action callback = null)
	{
	}

	private void UpdateCompetitiveTeamFromServerData(string[] competitiveTeamIds, Action callback = null)
	{
	}

	private void SetTeamCharacter(int index, Character character)
	{
	}

	private void SetCompetitiveTeamCharacter(int index, Character character)
	{
	}
}
