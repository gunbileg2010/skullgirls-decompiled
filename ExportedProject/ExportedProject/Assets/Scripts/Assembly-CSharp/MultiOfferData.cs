using System.Collections.Generic;
using UnityEngine;

public class MultiOfferData : GuidScriptableObject
{
	public class MultiOfferPopupContext
	{
		public MultiOfferData multiOfferData;

		public OfferServerData triggeringOffer;

		public OfferData.OfferPopupShownDelegate callback;

		public string metricsContext;

		public MultiOfferPopupContext(MultiOfferData multiofferData, OfferServerData triggeringOffer, OfferData.OfferPopupShownDelegate callback, string metricsContext = "")
		{
		}
	}

	[SerializeField]
	protected List<OfferData> offers;

	[SerializeField]
	protected PopupData popupData;

	[SerializeField]
	protected int priority;

	[SerializeField]
	protected bool enabled;

	public virtual bool ShouldShow(PurchaseManager purchaseManager, OfferServerData triggeringOffer, out int numberOfAvailableOffers, out int priority)
	{
		numberOfAvailableOffers = default(int);
		priority = default(int);
		return false;
	}

	public virtual void ShowOfferPopup(OfferServerData triggeringOffer, bool withDismissReminder, OfferData.OfferPopupShownDelegate callback, string additionalContext, bool shouldQueue = true)
	{
	}

	public List<OfferData> GetOffersList()
	{
		return null;
	}

	public bool IsEnabled()
	{
		return false;
	}
}
