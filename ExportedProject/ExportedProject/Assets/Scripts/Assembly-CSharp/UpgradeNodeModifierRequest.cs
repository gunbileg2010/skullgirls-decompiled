using System;

public class UpgradeNodeModifierRequest : NetworkRequest
{
	private string backendId;

	private int upgradeCount;

	private int newLevel;

	private int softCurrencyValue;

	public UpgradeNodeModifierRequest(CollectibleNodeModifier nodeModifier, int upgradeCount)
	{
	}

	public override void Send(Action callback)
	{
	}

	public int GetNewLevel()
	{
		return 0;
	}

	public int GetSoftCurrencyValue()
	{
		return 0;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
