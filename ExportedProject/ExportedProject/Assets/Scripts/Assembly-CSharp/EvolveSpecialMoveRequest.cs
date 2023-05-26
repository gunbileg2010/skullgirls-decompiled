using System;
using System.Collections.Generic;

public class EvolveSpecialMoveRequest : NetworkRequest
{
	private string backendId;

	private int evolveCount;

	private int newLevel;

	private int softCurrencyValue;

	private List<StatServerData> newStats;

	public EvolveSpecialMoveRequest(Gear specialMove, int evolveCount)
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

	public List<StatServerData> GetNewStats()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
