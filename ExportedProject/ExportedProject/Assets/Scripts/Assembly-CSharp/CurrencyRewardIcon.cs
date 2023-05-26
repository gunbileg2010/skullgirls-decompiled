using UnityEngine;
using UnityEngine.UI;

public class CurrencyRewardIcon : MonoBehaviour
{
	[SerializeField]
	private Image currencyGlow;

	[SerializeField]
	private Image currencyImage;

	[SerializeField]
	private Image randomImage;

	[SerializeField]
	private Outline currencyOutline;

	[SerializeField]
	private GameObject amountGO;

	[SerializeField]
	private Text amountText;

	[SerializeField]
	private float posOffsetIfAmountVisible;

	private const float shardRewardScaleMultiplier = 0.7f;

	private const float shardRewardAlphaMultiplier = 0.5f;

	private CurrencyType currencyType;

	private int amount;

	private int outOfAmount;

	public void PopulateBasicCurrencies(CurrencyType currencyType, int amount)
	{
	}

	public void PopulateCharacterCurrencies(CurrencyType currencyType, BaseCharacterData data, int amount)
	{
	}

	public void PopulateKeys(RarityTier tier, int amount)
	{
	}

	public void PopulateGachaShards(RarityTier tier, int amount)
	{
	}

	public void PopulateEssences(Element elementType, bool isShard, int amount)
	{
	}

	public void HideAmount()
	{
	}

	public void ShowOutOfAmount(int amount)
	{
	}

	public CurrencyType GetCurrencyType()
	{
		return default(CurrencyType);
	}

	private void RefreshAmount()
	{
	}

	private void SetCurrentGlowEnabled(CurrencyType currencyType, Element element = Element.Neutral, RarityTier tier = RarityTier.Bronze)
	{
	}

	private void SetCurrencyOutlineEnabled(bool value)
	{
	}

	private void ScootCurrencyForAmountCounter()
	{
	}
}
