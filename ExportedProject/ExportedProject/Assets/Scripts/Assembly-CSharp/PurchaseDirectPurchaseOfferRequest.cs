using System;
using System.Collections.Generic;

public class PurchaseDirectPurchaseOfferRequest : NetworkRequest
{
	private string storeType;

	private long itemId;

	private List<Reward> rewards;

	public PurchaseDirectPurchaseOfferRequest(string storeType, long itemId)
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
