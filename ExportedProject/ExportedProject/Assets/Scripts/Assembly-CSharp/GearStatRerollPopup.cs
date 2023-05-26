using UnityEngine;
using UnityEngine.UI;

public class GearStatRerollPopup : MasterPopup
{
	[SerializeField]
	private Transform moveIconAnchor;

	[SerializeField]
	private GearStatsContainerView statsContainerView;

	[SerializeField]
	private ToggleGroup toggleGroup;

	[SerializeField]
	private Toggle toggleOne;

	[SerializeField]
	private Toggle toggleTwo;

	[SerializeField]
	private Toggle toggleThree;

	[SerializeField]
	private MasterPopupData rerollStatsResultPopupData;

	[SerializeField]
	private AdvancedButton confirmButton;

	private GearDetailsView gearDetailsView;

	private Gear gear;

	private GearData gearData;

	private GearCard gearCard;

	private int statIndex;

	private Profile profile;

	private bool canAfford;

	public override void SetData(PopupData newPopupData)
	{
	}

	public override void Hide()
	{
	}

	public void UGUI_CancelButtonPressed()
	{
	}

	public void UGUI_ConfirmButtonPressed()
	{
	}

	public void UGUI_StatTogglePressed(int index)
	{
	}

	private void Populate()
	{
	}

	private void InitializeConfirmPurchaseButton()
	{
	}
}
