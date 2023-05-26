using System;

public class GetDirectPurchaseStoreRequest : NetworkRequest
{
	private DirectPurchaseStoreServerData directPurchaseStoreServerData;

	private bool rerollAllowed;

	public GetDirectPurchaseStoreRequest(bool rerollAllowed = true)
	{
	}

	public override void Send(Action callback)
	{
	}

	public DirectPurchaseStoreServerData GetStoreData()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
