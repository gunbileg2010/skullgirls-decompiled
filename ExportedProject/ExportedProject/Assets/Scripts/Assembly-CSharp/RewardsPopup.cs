using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardsPopup : SGUGUIPopup
{
	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private GameObject frameGO;

	[SerializeField]
	protected LocalizedUGUIText titleText;

	[SerializeField]
	protected RewardScrollView rewardScrollView;

	[SerializeField]
	private Button buttonPrototype;

	[SerializeField]
	private GachaShardProgressUI silverGachaShardProgress;

	[SerializeField]
	private GachaShardProgressUI goldGachaShardProgress;

	[SerializeField]
	private GachaShardProgressUI diamondGachaShardProgress;

	[SerializeField]
	private GameObject characterXPParentGameObject;

	[SerializeField]
	private CharacterCardXpContainer experienceLevelUpPrefab;

	[SerializeField]
	private Transform cardContainer;

	[SerializeField]
	private float delayBetweenCards;

	[SerializeField]
	private float cardAnimateInDuration;

	[SerializeField]
	private GameObject purchaseMoreBonusLabel;

	private RewardsPopupData rewardsPopupData;

	private bool shouldDisplayRewardsOnShow;

	private int cachedSilverGachaShards;

	private int cachedGoldGachaShards;

	private int cachedDiamondGachaShards;

	private CharacterCardXpContainer[] cardXPContainers;

	private CharacterCard[] characterCards;

	protected override void Awake()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public override void SetData(PopupData newPopupData)
	{
	}

	protected void ShowRewardsSequence()
	{
	}

	protected void OnShowGachaShards(RarityTier tier, int amount)
	{
	}

	private IEnumerator ShowCharacterXPRewards(List<XpRewardServerData> playerProgress, List<XpRewardServerData> characterProgress, bool otherRewards)
	{
		return null;
	}

	private IEnumerator ShowCharacterCards(List<XpRewardServerData> characterProgress)
	{
		return null;
	}

	private void FinishShowingCards(List<Character> characters, List<XpRewardServerData> characterProgress)
	{
	}
}
