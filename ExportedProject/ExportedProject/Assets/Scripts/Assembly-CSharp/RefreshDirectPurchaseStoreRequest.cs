using System;

public class RefreshDirectPurchaseStoreRequest : NetworkRequest
{
	private DirectPurchaseStoreServerData directPurchaseStoreServerData;

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
