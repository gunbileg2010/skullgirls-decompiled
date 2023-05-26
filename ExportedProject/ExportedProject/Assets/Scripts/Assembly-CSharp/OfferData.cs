using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OfferData : GuidScriptableObject
{
	public enum OfferTrigger : byte
	{
		None = 0,
		CompleteAct = 1,
		AcquireCharacter = 2,
		NotEnoughCurrency = 3,
		ReachMaxCharacterLevel = 4,
		ReachPlayerLevel = 5,
		MaxCharacterSkillTree = 6,
		CompleteAchievement = 7,
		EvolveCharacter = 8
	}

	public enum OfferType
	{
		LimitedOffers = 0,
		Subscription = 1,
		Recurring = 2,
		Currency = 3
	}

	private enum LTOAttractCurrencyStaticResource
	{
		None = 0,
		SC = 1,
		HC = 2,
		BronzeKey = 3,
		SilverKey = 4,
		GoldKey = 5,
		AirEssenceShard = 6,
		WaterEssenceShard = 7,
		FireEssenceShard = 8,
		LightEssenceShard = 9,
		DarkEssenceShard = 10,
		AirEssence = 11,
		WaterEssence = 12,
		FireEssence = 13,
		LightEssence = 14,
		DarkEssence = 15,
		SilverGachaShard = 16,
		GoldGachaShard = 17,
		DiamondGachaShard = 18,
		DiamondKey = 19,
		SkillPoints = 20,
		StandardGift = 21,
		GoldGift = 22,
		EnergyRefill = 23,
		RerollRune = 24,
		UniversalRerollRune = 25
	}

	[Serializable]
	public struct Notification
	{
		public float timeUntilExpirationHours;

		public string notificationKey;
	}

	[Serializable]
	public class StoreBannerData
	{
		public DynamicResource offerTableauPrefab;

		public DynamicResource offerTableauMultiFoldPrefab;

		public OfferTableau.TableauParams offerTableauData;

		public string contentDescription;

		public string featuredRewardDescription;

		public int relicOddsPopupIndex;

		public int rewardsPerRow;

		public float rewardsRowSpacing;

		public float rewardsRowHeight;

		public int rewardsRowPadding;

		public DynamicResource backgroundTexture;

		public Gradient backgroundGradient;

		public Vector2 backgroundUVAnimateSpeed;

		public Vector2 backgroundUVWidthHeight;
	}

	[Serializable]
	public class OfferPopupParams
	{
		public Vector2 rewardGridCellSize;

		public Vector2 rewardGridCellSpacing;

		public GridLayoutGroup.Constraint rewardGridLayoutConstraint;

		public int rewardGridLayoutConstraintCount;

		public bool showRewardDescriptions;

		public bool showFeaturedRewardDescription;

		[NonSerialized]
		public OfferServerData offerServerData;
	}

	public delegate void OfferPopupShownDelegate(bool success, params OfferServerData[] purchasedOffers);

	[SerializeField]
	private string title;

	[SerializeField]
	private int displayOrder;

	[SerializeField]
	private OfferType offerType;

	[SerializeField]
	private DynamicResource storeDecorationPrefab;

	[SerializeField]
	private StoreBannerData storeBannerData;

	[SerializeField]
	private DynamicResource attractButtonDynamicResource;

	[SerializeField]
	private LTOAttractCurrencyStaticResource attractButtonStaticResource;

	[SerializeField]
	private float attractButtonImageYOffset;

	[SerializeField]
	private Color attractButtonImageColor;

	[SerializeField]
	private bool attrackButtonFlipImage;

	[SerializeField]
	private BaseCharacterData attractButtonSkillPointBaseCharacterData;

	[SerializeField]
	private bool showPopupImmediately;

	[SerializeField]
	private int[] daysLeftToTrigger;

	[SerializeField]
	private PopupData popupData;

	[SerializeField]
	private OfferPopupParams popupParams;

	[SerializeField]
	protected float specificOfferPopupCooldownHours;

	[SerializeField]
	private GameObject teaseStickerPrefab;

	[SerializeField]
	private float teaseStickerScale;

	[SerializeField]
	private Notification[] notifications;

	[SerializeField]
	private OfferTrigger trigger;

	[SerializeField]
	private Act triggerCompleteActCondition;

	[SerializeField]
	private VariantCharacterData[] triggerCharacterConditions;

	[SerializeField]
	private CurrencyType triggerCurrencyTypeCondition;

	[SerializeField]
	private BaseCharacterData[] triggerBaseCharacterConditions;

	[SerializeField]
	private RarityTier[] triggerRarityTierConditions;

	[SerializeField]
	private int[] triggerIntConditions;

	[SerializeField]
	private AchievementData[] triggerAchievementConditions;

	[SerializeField]
	private string[] triggerTags;

	[SerializeField]
	private long triggerFrequencyMinutes;

	[SerializeField]
	private long durationMinutes;

	[SerializeField]
	private int purchaseLimit;

	[SerializeField]
	protected OfferLoots offerLoots;

	public string GetTitle()
	{
		return null;
	}

	public GameObject TakeStoreDecorationPrefab()
	{
		return null;
	}

	public void ReturnStoreDecorationPrefab()
	{
	}

	public bool ShouldShowPopupImmediately()
	{
		return false;
	}

	public void ShowOfferPopup(OfferServerData serverData, bool withDismissReminder, OfferPopupShownDelegate callback, string additionalContext, bool allowMultifold = true, bool shouldQueue = true)
	{
	}

	public bool CanShowOfferPopupOnDay(int day)
	{
		return false;
	}

	public int GetNotificationsCount()
	{
		return 0;
	}

	public DateTime GetNotificationTargetDate(int idx, DateTime expirationDate)
	{
		return default(DateTime);
	}

	public string GetNotificationMessage(int idx)
	{
		return null;
	}

	public StoreBannerData GetStoreBannerData()
	{
		return null;
	}

	public int GetRelicOddsPopupIndex()
	{
		return 0;
	}

	public bool HasTeaseSticker()
	{
		return false;
	}

	public Transform GetTeaseStickerPrefab()
	{
		return null;
	}

	public float GetTeaseStickerScale()
	{
		return 0f;
	}

	public int GetPurchaseLimit()
	{
		return 0;
	}

	public virtual void ExecutePurchase(OfferServerData offerData, string context, Action<bool> callback)
	{
	}

	public virtual PurchaseAction GetPurchaseActionAtIndex(int index)
	{
		return null;
	}

	public virtual List<PurchaseAction> GetAllPurchaseActions()
	{
		return null;
	}

	public OfferLoots GetOfferLoots()
	{
		return null;
	}

	public PurchaseAction GetPurchaseAction()
	{
		return null;
	}

	public bool HasProductId(string productId)
	{
		return false;
	}

	public List<Loot> GetPaidLoots()
	{
		return null;
	}

	public List<Loot> GetBonusLoots()
	{
		return null;
	}

	public bool HasDynamicAttractButtonImage()
	{
		return false;
	}

	public DynamicResource GetAttractButtonDynamicResource()
	{
		return null;
	}

	public bool HasStaticAttractButtonImage()
	{
		return false;
	}

	public Sprite GetAttractButtonStaticResource()
	{
		return null;
	}

	public Material GetAttractButtonStaticImageMaterial()
	{
		return null;
	}

	public Color GetAttractButtonImageColor()
	{
		return default(Color);
	}

	public float GetAttractButtonYOffset()
	{
		return 0f;
	}

	public bool GetAttrackButtonFlipImage()
	{
		return false;
	}

	public OfferType GetOfferType()
	{
		return default(OfferType);
	}

	public virtual Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
