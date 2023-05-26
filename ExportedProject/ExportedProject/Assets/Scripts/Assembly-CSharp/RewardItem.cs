using UnityEngine;
using UnityEngine.UI;

public class RewardItem : MonoBehaviour
{
	public enum SocialSetting
	{
		NotSocial = 0,
		Standard = 1,
		Gold = 2
	}

	public enum FrameSetting
	{
		Standard = 0,
		Clickable = 1
	}

	public class DisplayOptions
	{
		public bool isBonus;

		public FrameSetting frameSetting;

		public SocialSetting socialSetting;

		public DisplayOptions()
		{
		}

		public DisplayOptions(bool isBonus, SocialSetting socialSetting)
		{
		}

		public DisplayOptions(bool isBonus, SocialSetting socialSetting, FrameSetting frameSetting)
		{
		}
	}

	[SerializeField]
	private CurrencyRewardIcon currencyRewardPrefab;

	[SerializeField]
	private CharacterPortrait characterRewardPrefab;

	[SerializeField]
	private GachaRewardIcon gachaRewardPrefab;

	[SerializeField]
	private ConsumableRewardIcon consumableRewardPrefab;

	[SerializeField]
	private CurrencyRewardIcon currencyReward;

	[SerializeField]
	private GachaRewardIcon gachaReward;

	[SerializeField]
	private ConsumableRewardIcon consumableReward;

	[SerializeField]
	private CharacterPortrait characterReward;

	[SerializeField]
	private Button rewardButton;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private GameObject bonusBadge;

	[SerializeField]
	private Image frameImage;

	[SerializeField]
	private GameObject clickableFrameGO;

	[SerializeField]
	private Color standardFrameColor;

	[SerializeField]
	private GameObject goldGiftGlowGO;

	[SerializeField]
	private AnimationHelper animHelper;

	[SerializeField]
	private AnimationClip introClip;

	[SerializeField]
	private float gearCardScale;

	[SerializeField]
	private float nodeModifierCardVerticleNudge;

	[SerializeField]
	private bool recycleOnDisable;

	private GearCard specialReward;

	private GearCard blockbusterReward;

	private CollectibleNodeModifierCard nodeModifierReward;

	private Reward myReward;

	private Loot myLoot;

	private bool isRandom;

	private string overrideTooltipDescription;

	private string overrideTooltipHeader;

	private ContextualPopupItem showingTooltip;

	private int cachedSoftCurrencyValue;

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void Populate(Reward reward, DisplayOptions extraOptions)
	{
	}

	public void Populate(Reward reward, bool displayAsRandom = false, int randomAmount = 0)
	{
	}

	public void Clear()
	{
	}

	public void ShowIntro()
	{
	}

	public bool IsPlayingAnim()
	{
		return false;
	}

	public void SetOverrideTooltipHeader(string title)
	{
	}

	public void SetOverrideTooltipDescription(string description)
	{
	}

	public void ShowBonusBadge()
	{
	}

	public void ShowFrame()
	{
	}

	public void HideFrame()
	{
	}

	public void HideAmount()
	{
	}

	public void ShowOutOfAmount(int amount)
	{
	}

	public void SetRewardHeights(float height)
	{
	}

	public void UGUI_Pressed()
	{
	}

	public void SetButtonInteractive(bool interactive)
	{
	}

	private void ShowTooltip()
	{
	}

	private void ToggleClickableFrame(bool show)
	{
	}

	private void ChangeFrameAlpha(float alpha)
	{
	}

	private void ReturnResources()
	{
	}

	private void OnRewardItemSold()
	{
	}

	private void OnRewardItemUpgraded()
	{
	}
}
