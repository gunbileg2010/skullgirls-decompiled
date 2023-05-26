using System;
using System.Collections.Generic;

public class GetAccountsRequest : NetworkRequest
{
	private List<AccountServerData> accountBindings;

	public override void Send(Action callback)
	{
	}

	public List<AccountServerData> GetAccountBindings()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
