using System;
using System.Collections.Generic;

public class GetOwnedGachasRequest : NetworkRequest
{
	private Dictionary<string, int> ownedGachas;

	private int totalGachaCount;

	public override void Send(Action callback)
	{
	}

	public Dictionary<string, int> GetOwnedGachas()
	{
		return null;
	}

	public int GetTotalOwnedGachas()
	{
		return 0;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
