using UnityEngine;

public class BundleOfferStoreListView : MonoBehaviour
{
	[SerializeField]
	private BundleOfferStoreListItem prefab;

	[SerializeField]
	private Transform listTransform;

	private void OnDisable()
	{
	}

	public void Populate()
	{
	}

	public void Clear()
	{
	}

	private void OnBundlesPurchased(params OfferServerData[] purchasedOffers)
	{
	}
}
