using System;
using System.Collections.Generic;

public class ClaimFreeEventTicketsRequest : NetworkRequest
{
	private List<Reward> rewards;

	private DateTime newFreeEventTicketResetTime;

	private CurrencyType currencyType;

	public ClaimFreeEventTicketsRequest(CurrencyType currencyType)
	{
	}

	public override void Send(Action callback)
	{
	}

	public List<Reward> GetRewards()
	{
		return null;
	}

	public DateTime GetNewFreeEventTicketResetTime()
	{
		return default(DateTime);
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
