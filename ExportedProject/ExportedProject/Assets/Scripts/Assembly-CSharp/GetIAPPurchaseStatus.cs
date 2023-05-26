using System;
using System.Runtime.CompilerServices;

public class GetIAPPurchaseStatus : NetworkRequest
{
	private string iapPurchaseInstanceId;

	public PurchaseStatusServerData purchaseDataStatus
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

	public GetIAPPurchaseStatus(string iapPurchaseInstanceId)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
