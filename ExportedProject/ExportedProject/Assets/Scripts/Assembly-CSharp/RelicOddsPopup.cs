using System;
using UnityEngine;
using UnityEngine.UI;

public class RelicOddsPopup : SGUGUIPopup
{
	[Serializable]
	public class RelicOddsInfoSet
	{
		public OddsHeaderButton assignedButton;

		public GachaData refGachaForIcon;

		public string decBodyLocKey;

		public OddsLineItemInfo[] lineItems;

		public bool hasBonusLine;

		public Transform teaseStickerPrefab;

		public float teaseStickerScale;
	}

	[Serializable]
	public class OddsLineItemInfo
	{
		public string rowNameLocKey;

		public float primaryOddsPercent;

		public float bonusOddsPercent;

		public bool primaryIsApprox;

		public bool bonusIsApprox;
	}

	[Serializable]
	public class OddsLine
	{
		public GameObject rowHeaderObject;

		public LocalizedUGUIText rowHeaderText;

		public GameObject generalOddsObject;

		public Text generalOddsText;

		public GameObject bonusOddsObject;

		public Text bonusOddsText;

		public void TurnOffAll()
		{
		}

		public void TurnOn(string displayStringLocKey, float oddsValue, float bonusOddsValue, bool approxPrime, bool approxBonus)
		{
		}
	}

	[SerializeField]
	private RelicOddsInfoSet[] relicInfoSets;

	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private LocalizedUGUIText descBodyText;

	[SerializeField]
	private ToggleGroupRowController rowController;

	[SerializeField]
	private GridLayoutGroup oddsGridLayoutGroup;

	[SerializeField]
	private OddsLine[] oddsDisplayLines;

	[SerializeField]
	private GameObject bonusRelicColumnHeader;

	[SerializeField]
	private TeaseStickerParent teaseStickerParent;

	private bool mustRefreshToggleIndexes;

	protected override void Awake()
	{
	}

	public void DisplayOddsInfo(int indexToShow)
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public override void SetData(PopupData newPopupData)
	{
	}
}
