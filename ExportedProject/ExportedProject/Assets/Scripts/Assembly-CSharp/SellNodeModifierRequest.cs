using System;
using System.Collections.Generic;

public class SellNodeModifierRequest : NetworkRequest
{
	private List<string> backendIds;

	private List<Reward> rewardsEarned;

	public SellNodeModifierRequest(CollectibleNodeModifier nodeModifiers)
	{
	}

	public SellNodeModifierRequest(List<CollectibleNodeModifier> nodeModifiersList)
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
