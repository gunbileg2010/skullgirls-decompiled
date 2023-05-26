using System;
using System.Collections.Generic;
using UnityEngine;

public class FeaturedOfferData : GuidScriptableObject
{
	public class FeaturedOfferPopupContext
	{
		public FeaturedOfferData featuredOfferData;

		public string metricsContext;

		public FeaturedOfferPopupContext(FeaturedOfferData featuredOfferData, string metricsContext = "")
		{
		}
	}

	[Serializable]
	public class OfferWithDisplayParams
	{
		public OfferData offer;

		public string purchaseButtonTextOverride;

		public string purchaseHeaderText;

		public string[] purchaseHeaderSubstitutions;

		public bool showDiamondBanner;

		public bool hideLootIcons;
	}

	public string title;

	public string description;

	[SerializeField]
	private List<OfferWithDisplayParams> offers;

	[SerializeField]
	public int priority;

	[SerializeField]
	public bool enabled;

	[SerializeField]
	public float offerPanelHeightPercentage;

	public DynamicResource offerTableauPrefab;

	public OfferTableau.TableauParams tableauParams;

	public DynamicResource backgroundTexture;

	[NonSerialized]
	private List<OfferData> offersList;

	public bool ShouldShow(PurchaseManager purchaseManager, OfferServerData triggeringOffer, out int numberOfAvailableOffers, out int priority)
	{
		numberOfAvailableOffers = default(int);
		priority = default(int);
		return false;
	}

	public List<OfferWithDisplayParams> GetOffersWithDisplayParams()
	{
		return null;
	}

	public List<OfferData> GetOffersList()
	{
		return null;
	}

	public bool IsEnabled()
	{
		return false;
	}

	private void BuildOffersList()
	{
	}
}
