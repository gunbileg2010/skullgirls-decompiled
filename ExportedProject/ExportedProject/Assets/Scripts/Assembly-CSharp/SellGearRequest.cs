using System;
using System.Collections.Generic;

public class SellGearRequest : NetworkRequest
{
	private List<string> backendIds;

	private List<Reward> rewardsEarned;

	public SellGearRequest(Gear gear)
	{
	}

	public SellGearRequest(List<Gear> gearList)
	{
	}

	public override void Send(Action callback)
	{
	}

	public List<Reward> GetRewardsEarned()
	{
		return null;
	}

	public int GetSoftCurrencyEarned()
	{
		return 0;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
