using System;
using System.Collections.Generic;

public class PurchaseCurrencyStoreOfferRequest : NetworkRequest
{
	private string instanceId;

	private bool isLTO;

	private bool isUserOffer;

	private List<Reward> rewards;

	public PurchaseCurrencyStoreOfferRequest(string instanceId, bool isLTO = false, bool isUserOffer = false)
	{
	}

	public override void Send(Action callback)
	{
	}

	public List<Reward> GetRewards()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
