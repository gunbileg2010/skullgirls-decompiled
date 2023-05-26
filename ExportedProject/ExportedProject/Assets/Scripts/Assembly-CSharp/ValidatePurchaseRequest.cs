using System;
using System.Collections.Generic;

public class ValidatePurchaseRequest : NetworkRequest
{
	private string offerId;

	private string receiptData;

	private string orderId;

	private string productId;

	private bool grantViaMail;

	private PurchaseStatusServerData purchaseStatusData;

	public ValidatePurchaseRequest(string offerId, string orderId, string receiptData, string productId, bool grantViaMail = false)
	{
	}

	public override void Send(Action callback)
	{
	}

	public PurchaseStatusServerData GetPurchaseStatusServerData()
	{
		return null;
	}

	public List<Reward> GetPurchaseRewards()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
