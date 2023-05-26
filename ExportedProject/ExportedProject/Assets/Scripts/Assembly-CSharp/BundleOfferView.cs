using System;
using UnityEngine;
using UnityEngine.UI;

public class BundleOfferView : MonoBehaviour
{
	[SerializeField]
	private Transform tableauParentTransform;

	[SerializeField]
	private bool useMultiFoldTableau;

	[SerializeField]
	private RawImage backgroundImage;

	[SerializeField]
	private UIGradientMapped backgroundGradient;

	[SerializeField]
	private TimerUI timerToExpirationDate;

	[SerializeField]
	private LocalizedUGUIText title;

	[SerializeField]
	private LocalizedUGUIText description;

	[SerializeField]
	private LocalizedUGUIText featuredRewardText;

	[SerializeField]
	private AdvancedButton purchaseButton;

	[SerializeField]
	private GameObject purchaseButtonGlow;

	[SerializeField]
	private GameObject purchaseButtonSparkles;

	[SerializeField]
	private GameObject saleStickerGO;

	[SerializeField]
	private LocalizedUGUIText saleStickerText;

	[SerializeField]
	private TeaseStickerParent teaseStickerParent;

	[SerializeField]
	private GameObject stickerBackingGlow;

	private Action timerFinished;

	private OfferData.StoreBannerData storeBannerData;

	private OfferTableau tableau;

	private DynamicResource cachedBackgroundTexture;

	private Vector2 backgroundUVAnimateSpeed;

	public void Update()
	{
	}

	public void Populate(OfferServerData ltoServerData, Action expirationCallback)
	{
	}

	public void Clear()
	{
	}

	public void SetPriceButton(OfferServerData ltoServerData)
	{
	}

	private void SetText(LocalizedUGUIText text, string key)
	{
	}
}
