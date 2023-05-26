using UnityEngine;
using UnityEngine.UI;

public class ConsumableRewardIcon : MonoBehaviour
{
	[SerializeField]
	private Image consumableImage;

	[SerializeField]
	private GameObject amountGO;

	[SerializeField]
	private Text amountText;

	[SerializeField]
	private GameObject newSticker;

	[SerializeField]
	private Text effectAmountText;

	private ConsumableData myConsumableData;

	public void Populate(ConsumableData consumableData, int amount = 1)
	{
	}

	public void Clear()
	{
	}

	public void HideAmount()
	{
	}

	public void SetAmount(int amount)
	{
	}
}
