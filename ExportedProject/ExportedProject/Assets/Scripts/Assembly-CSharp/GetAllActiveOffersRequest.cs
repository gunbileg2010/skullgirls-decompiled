using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class GetAllActiveOffersRequest : NetworkRequest
{
	private string region;

	public List<OfferServerData> moneyStoreOffers
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public List<OfferServerData> currencyStoreOffers
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public List<OfferServerData> bundleStoreOffers
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public List<OfferServerData> limitedTimeOffers
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public List<string> blockedMultiOfferGuids
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public GetAllActiveOffersRequest(string region)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
