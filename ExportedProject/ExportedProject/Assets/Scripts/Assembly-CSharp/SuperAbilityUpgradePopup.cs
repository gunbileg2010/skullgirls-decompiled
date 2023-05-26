using UnityEngine;

public class SuperAbilityUpgradePopup : MasterPopup
{
	[SerializeField]
	private LocalizedUGUIText titleText;

	[SerializeField]
	private LocalizedUGUIText currentLevelText;

	[SerializeField]
	private LocalizedUGUIText upgradeLevelText;

	[SerializeField]
	private LocalizedUGUIText abilityText;

	[SerializeField]
	private AdvancedButton upgradeConfirmButton;

	private Character character;

	private ArtSettings artSettings;

	private int featureSet;

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
