using UnityEngine;

public class GearUpgradePopup : MasterPopup
{
	[SerializeField]
	private LocalizedUGUIText titleText;

	[SerializeField]
	private GameObject specialMoveSpecificGo;

	[SerializeField]
	private GameObject specialMoveCooldownUpgradeArrow;

	[SerializeField]
	private GameObject finePrintTextGO;

	[SerializeField]
	private GearStatsContainerView statsContainerView;

	private Gear gear;

	private GearData gearData;

	private int savedNavConfig;

	private string savedCurrencyConfig;

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public override void SetData(PopupData newPopupData)
	{
	}

	private void Populate()
	{
	}
}
