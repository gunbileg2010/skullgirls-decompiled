using UnityEngine;
using UnityEngine.UI;

public class FundSettlementDisplayActPopup : SGUGUIPopup
{
	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private Text hardFreeCount;

	[SerializeField]
	private Text hardPaidCount;

	[SerializeField]
	private Text hardTotalCount;

	[SerializeField]
	private Text softFreeCount;

	[SerializeField]
	private Text softPaidCount;

	[SerializeField]
	private Text softTotalCount;

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	private void SetText(Text text, int value)
	{
	}
}
