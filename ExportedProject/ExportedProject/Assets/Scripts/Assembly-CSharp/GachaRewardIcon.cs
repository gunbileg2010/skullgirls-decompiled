using UnityEngine;
using UnityEngine.UI;

public class GachaRewardIcon : MonoBehaviour
{
	[SerializeField]
	private Image gachaImage;

	[SerializeField]
	private GameObject amountGO;

	[SerializeField]
	private Text amountText;

	[SerializeField]
	private GameObject randomIcon;

	[SerializeField]
	private UIGradientMapped gradientMap;

	[SerializeField]
	private GameObject voucherAdditionImage;

	[SerializeField]
	private Text voucherAmount;

	private GachaData myGachaData;

	public void Populate(GachaData gachaData, int amount = 1, Loot loot = null)
	{
	}

	public void SetVoucherStatus(bool isVoucher, string denominationString)
	{
	}

	public void Clear()
	{
	}

	public void HideAmount()
	{
	}

	public void ShowAsRandom(bool isRandom)
	{
	}
}
