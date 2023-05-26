public class GhostOfferServerData : OfferServerData
{
	public GhostOfferServerData(OfferData sourceOfferData)
	{
	}

	public override bool IsAvailable()
	{
		return false;
	}

	public override bool CanBePurchased()
	{
		return false;
	}

	public override string GetOfferId()
	{
		return null;
	}
}
