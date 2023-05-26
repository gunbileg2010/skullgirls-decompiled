using UnityEngine;

public class CollectibleNodeModifierUpgradePopup : MasterPopup
{
	[SerializeField]
	private LocalizedUGUIText titleText;

	[SerializeField]
	private LocalizedUGUIText currentLevelText;

	[SerializeField]
	private LocalizedUGUIText upgradeLevelText;

	[SerializeField]
	private LocalizedUGUIText abilityText;

	private CollectibleNodeModifier collectibleNodeModifier;

	private CollectibleNodeModifierData collectibleNodeModifierData;

	private ArtSettings artSettings;

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
