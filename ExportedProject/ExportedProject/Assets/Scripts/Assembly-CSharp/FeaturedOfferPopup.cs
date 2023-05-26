using UnityEngine;
using UnityEngine.UI;

public class FeaturedOfferPopup : SGUGUIPopup
{
	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private FeaturedOfferView featuredOfferView;

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	private string GetMetricStringFromContext(FeaturedOfferData.FeaturedOfferPopupContext context)
	{
		return null;
	}
}
