using System;
using System.Collections.Generic;

public class PurchaseGachaRequest : NetworkRequest
{
	private string guid;

	private int amount;

	private bool isVoucherPurchase;

	private int voucherDenomination;

	private GachaOpenServerData gachaOpenServerData;

	public PurchaseGachaRequest(string inGachaGuid, int inAmount)
	{
	}

	public void SetIsVoucherPurchase(bool isVoucherPurchase, int voucherDenomination)
	{
	}

	public override void Send(Action callback)
	{
	}

	public List<List<Reward>> GetRewardsPerGacha()
	{
		return null;
	}

	public List<Reward> GetRewards()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
