using UnityEngine;

public class GearStatRerollResultsPopup : MasterPopup
{
	[SerializeField]
	private Transform moveIconAnchor;

	[SerializeField]
	private GearStatsContainerView statsContainerView;

	[SerializeField]
	private MasterPopupData rerollStatsPopupData;

	private GearDetailsView gearDetailsView;

	private Gear gear;

	private GearCard gearCard;

	public override void SetData(PopupData newPopupData)
	{
	}

	public override void Hide()
	{
	}

	public void UGUI_RejectButtonPressed()
	{
	}

	public void UGUI_AcceptButtonPressed()
	{
	}

	private void Populate()
	{
	}

	private void ConfirmRerollSelected(bool accepted)
	{
	}
}
