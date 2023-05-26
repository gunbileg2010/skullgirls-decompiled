using UnityEngine;

public class PrestigeAbilityUpgradeDetailsPopup : MasterPopup
{
	[SerializeField]
	private SignatureAbilityView currentAbility;

	[SerializeField]
	private SignatureAbilityView upgradedAbility;

	public override void SetData(PopupData newPopupData)
	{
	}
}
