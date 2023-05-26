using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
	[SerializeField]
	private List<VariantCharacterData> characterCards;

	[SerializeField]
	private CharacterCard characterCardPrefab;

	[SerializeField]
	private GearCard specialMoveCardPrefab;

	[SerializeField]
	private GearCard blockbusterCardPrefab;

	[SerializeField]
	private GearCardHolder gearCardHolderPrefab;

	[SerializeField]
	private CollectibleNodeModifierCard nodeModifierCardPrefab;

	[SerializeField]
	private RewardItem rewardItemPrefab;

	[SerializeField]
	private CharacterPortrait characterPortraitPrefab;

	public int obtainableBronzeVariantCount;

	public int obtainableSilverVariantCount;

	public int obtainableGoldVariantCount;

	public int obtainableDiamondVariantCount;

	private GameObjectPool<CharacterCard> characterCardPool;

	private GameObjectPool<GearCard> specialMoveCardPool;

	private GameObjectPool<GearCard> blockbusterCardPool;

	private GameObjectPool<GearCardHolder> gearCardHolderPool;

	private GameObjectPool<CollectibleNodeModifierCard> nodeModifierCardPool;

	private GameObjectPool<RewardItem> rewardItemPool;

	private GameObjectPool<CharacterPortrait> characterPortraitPool;

	private List<BaseCharacterData> baseCharacterDatas;

	private void Awake()
	{
	}

	public BaseCharacterData GetBaseCharacterDataByGuid(string guid)
	{
		return null;
	}

	public List<BaseCharacterData> GetAllBaseCharacterDatas()
	{
		return null;
	}

	public VariantCharacterData GetVariantCharacterDataByGuid(string guid)
	{
		return null;
	}

	public List<VariantCharacterData> GetCompetitiveCharacterCollection()
	{
		return null;
	}

	public Dictionary<string, List<GearData>> GetCompetitiveGearCollection()
	{
		return null;
	}

	public List<VariantCharacterData> GetAllVariantCharacterDatas()
	{
		return null;
	}

	public GearData GetGearDataByGuid(string guid)
	{
		return null;
	}

	public BaseCharacterData GetBaseCharacterDataForGearData(GearData gearData)
	{
		return null;
	}

	public SkillTree GetSkillTreeByGuid(string guid)
	{
		return null;
	}

	public CharacterCard TakeCharacterCard()
	{
		return null;
	}

	public void ReturnCharacterCard(CharacterCard card)
	{
	}

	public GearCard TakeGearCard(GearType gearType = GearType.SpecialMove)
	{
		return null;
	}

	public void ReturnGearCard(GearCard card)
	{
	}

	public CollectibleNodeModifierCard TakeNodeModifierCard()
	{
		return null;
	}

	public void ReturnNodeModifierCard(CollectibleNodeModifierCard card)
	{
	}

	public RewardItem TakeRewardItem(Loot loot)
	{
		return null;
	}

	public RewardItem TakeRewardItem(Reward reward, RewardItem.DisplayOptions extraOptions = null)
	{
		return null;
	}

	public void ReturnRewardItem(RewardItem rewardItem)
	{
	}

	public GearCardHolder TakeGearCardHolder()
	{
		return null;
	}

	public void ReturnGearCardHolder(GearCardHolder card)
	{
	}

	public CharacterPortrait TakeCharacterPortrait()
	{
		return null;
	}

	public void ReturnCharacterPortrait(CharacterPortrait characterPortrait)
	{
	}

	public void ApplySyncPvpPrefightDataUpdate(SyncPvpPrefightServerData data)
	{
	}

	public void CalculateAvailableVariantsForEachRarityTier()
	{
	}

	public BaseCharacterData GetNextBaseCharacter(BaseCharacterData current)
	{
		return null;
	}

	public VariantCharacterData GetFirstVariantCharacterForBaseCharacter(BaseCharacterData baseCharacterData)
	{
		return null;
	}

	public VariantCharacterData GetNextVariantCharacter(VariantCharacterData current)
	{
		return null;
	}

	private CharacterCard CreateNewCharacterCard()
	{
		return null;
	}

	private GearCardHolder CreateNewGearCardHolder()
	{
		return null;
	}

	private GearCard CreateNewSpecialMoveCard()
	{
		return null;
	}

	private GearCard CreateNewBlockbusterCard()
	{
		return null;
	}

	private CollectibleNodeModifierCard CreateNewCollectibleNodeModifierCard()
	{
		return null;
	}

	private RewardItem CreateNewRewardItem()
	{
		return null;
	}

	private CharacterPortrait CreateNewCharacterPortrait()
	{
		return null;
	}
}
