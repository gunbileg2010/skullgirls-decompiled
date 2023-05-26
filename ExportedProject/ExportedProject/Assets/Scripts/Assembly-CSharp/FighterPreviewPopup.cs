using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FighterPreviewPopup : SGUGUIPopup
{
	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private RectTransform cardPosition;

	[SerializeField]
	private FullAbilitiesView fullAbilitiesView;

	[SerializeField]
	private List<GearCardSlot> gearSlots;

	private Character character;

	private CharacterCard characterCard;

	private List<GearCardHolder> gearCardHolders;

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	private void Populate()
	{
	}

	private void CleanUp()
	{
	}

	private void PopulateGear()
	{
	}

	private void PutGearInEquippedGearSlot(Gear gear, GearCardSlot slot)
	{
	}

	private void OnGearSelected(GearCardHolder gearCardHolder)
	{
	}
}
