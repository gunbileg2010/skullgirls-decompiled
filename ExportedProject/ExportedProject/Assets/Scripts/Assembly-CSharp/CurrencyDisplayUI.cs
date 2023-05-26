using UnityEngine;
using UnityEngine.UI;

public class CurrencyDisplayUI : MonoBehaviour
{
	[SerializeField]
	private GameObject hardCurrencyIcon;

	[SerializeField]
	private GameObject softCurrencyIcon;

	[SerializeField]
	private GameObject gachaShardIcon;

	[SerializeField]
	private Image gachaShardImage;

	[SerializeField]
	private GameObject skillPointsIcon;

	[SerializeField]
	private Image skillPointsImage;

	[SerializeField]
	private GameObject keyIcon;

	[SerializeField]
	private Image keyImage;

	[SerializeField]
	private GameObject essenceIcon;

	[SerializeField]
	private Image essenceImage;

	[SerializeField]
	private Text currencyValue;

	[SerializeField]
	private GameObject battleCurrencyIcon;

	[SerializeField]
	private GameObject energyRefillCurrencyIcon;

	[SerializeField]
	private GameObject socialGiftStandardIcon;

	[SerializeField]
	private GameObject socialGiftGoldIcon;

	[SerializeField]
	private GameObject freeBattleTicketIcon;

	[SerializeField]
	private GameObject paidBattleTicketIcon;

	[SerializeField]
	private GameObject dailyEventTicketIcon;

	[SerializeField]
	private GameObject characterGachaShardIcon;

	[SerializeField]
	private Image characterGachaShardImage;

	[SerializeField]
	private GameObject rerollRuneIcon;

	[SerializeField]
	private Image rerollRuneImage;

	[SerializeField]
	private GameObject universalRerollRuneIcon;

	[SerializeField]
	private GachaRewardIcon voucherIcon;

	private bool usePlusSign;

	private int cachedAmount;

	public void ClearAll()
	{
	}

	public void SetUsePlusSign(bool usePlusSign)
	{
	}

	public void ShowHardCurrency(int amount)
	{
	}

	public void ShowSoftCurrency(int amount)
	{
	}

	public void ShowGachaShards(RarityTier tier, int amount)
	{
	}

	public void ShowSkillPoints(BaseCharacterData baseCharacterData, int amount)
	{
	}

	public void ShowKeys(RarityTier tier, int amount)
	{
	}

	public void ShowEssences(Element element, int amount)
	{
	}

	public void ShowDisplayPrice(string displayPrice)
	{
	}

	public void ShowBattleCurrency(int amount)
	{
	}

	public void ShowSocialGiftStandard(int amount)
	{
	}

	public void ShowSocialGiftGold(int amount)
	{
	}

	public void ShowEnergyRefillCurrency(int amount)
	{
	}

	public void ShowBattleTicket(bool paid, int amount)
	{
	}

	public void ShowDailyEventTicket(int amount)
	{
	}

	public void ShowCharacterGachaShard(int amount)
	{
	}

	public void ShowRerollRune(BaseCharacterData baseCharacterData, int amount)
	{
	}

	public void ShowUniversalRerollRune(int amount)
	{
	}

	public void ShowVoucher(GachaData gacha, int amount, string denominationString)
	{
	}

	public void UpdateAmount(int amount)
	{
	}

	private string GetAmountAsString(int amount)
	{
		return null;
	}

	private void ShowCurrency(int amount, GameObject currencyIcon)
	{
	}
}
