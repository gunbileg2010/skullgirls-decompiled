using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CollectibleIcon : UIBehaviour, ILayoutSelfController, ILayoutController
{
	[SerializeField]
	private Image currencyImage;

	[SerializeField]
	private Image keyImage;

	[SerializeField]
	private GachaRewardIcon internalGachaIcon;

	[SerializeField]
	private Image consumableImage;

	[SerializeField]
	private GameObject consumableTimeVisualsGO;

	[SerializeField]
	private Text consumableEffectText;

	[SerializeField]
	private Image essenceImage;

	[SerializeField]
	private Text amountText;

	[SerializeField]
	private float nodeModifierCardVerticleNudge;

	private GearCard specialReward;

	private GearCard blockbusterReward;

	private CharacterPortrait characterReward;

	private ConsumableData consumableData;

	private CollectibleNodeModifierCard nodeModifierReward;

	private static Vector3[] rectPoints;

	private static Vector3[] childRectPoints;

	private Loot myLoot;

	private bool isRandom;

	protected override void OnDestroy()
	{
	}

	public void Populate(Loot loot, int amountOverride = -1, bool displayAsRandom = false)
	{
	}

	public void Clear()
	{
	}

	public virtual void SetLayoutHorizontal()
	{
	}

	public virtual void SetLayoutVertical()
	{
	}

	public void UGUI_IconPressed()
	{
	}

	private void Populate(GachaData gachaData, int amount, Loot loot = null)
	{
	}

	private void Populate(ConsumableData consumableData, int amount)
	{
	}

	private void Populate(CurrencyType currencyType, int amount)
	{
	}

	private void Populate(CurrencyType currencyType, int amount, Element element)
	{
	}

	private void Populate(CurrencyType currencyType, RarityTier tier, int amount)
	{
	}

	private void Populate(CurrencyType currencyType, BaseCharacterData baseData, int amount)
	{
	}

	private void Populate(VariantCharacterData variantCharacter, int amount)
	{
	}

	private void Populate(GearData gearData, int amount, bool displayAsRandom)
	{
	}

	private void Populate(Loot loot, CollectibleNodeModifierData nodeModifierData, int amount, bool displayAsRandom)
	{
	}

	protected override void OnRectTransformDimensionsChange()
	{
	}

	private void RefreshWidth()
	{
	}

	private void UpdateWidthPointRecursively(RectTransform parentTransform, ref Vector3 pos)
	{
	}

	private void ShowTooltip()
	{
	}
}
