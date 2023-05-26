using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GearLoadoutView : MonoBehaviour
{
	[SerializeField]
	private List<GearCardSlot> gearSlots;

	[SerializeField]
	private GameObject buttonsParentGO;

	[SerializeField]
	private AdvancedButton equipButton;

	[SerializeField]
	private Button equipButtonHelper;

	[SerializeField]
	private AdvancedButton saveButton;

	[SerializeField]
	private Button saveButtonHelper;

	[SerializeField]
	private LocalizedUGUIText gearPointsText;

	[SerializeField]
	private GameObject selectableAreaGO;

	[SerializeField]
	private LayoutElement layoutElement;

	[SerializeField]
	private Transform equippedGearTransform;

	[SerializeField]
	private GameObject equippedGO;

	[SerializeField]
	private int selectedHeight;

	[SerializeField]
	private int deselectedHeight;

	[SerializeField]
	private float selectedScale;

	[SerializeField]
	private float deselectedScale;

	private GearEquipController gearEquipController;

	private GearLoadoutsPanel gearLoadoutsPanel;

	private Character character;

	private GearLoadout gearLoadout;

	private Dictionary<Gear, GearCardHolder> cardHolders;

	private bool isSelected;

	private Gear selectedGear;

	private void OnDestroy()
	{
	}

	public void Init(GearEquipController gearEquipController, GearLoadoutsPanel gearLoadoutsPanel)
	{
	}

	public void Populate(Character character, GearLoadout gearLoadout = null)
	{
	}

	public void Cleanup()
	{
	}

	public void SetSelected(bool selected)
	{
	}

	public void SetEquipped(bool equipped)
	{
	}

	public GearLoadout GetGearLoadout()
	{
		return null;
	}

	public void UGUI_LoadoutPressed()
	{
	}

	public void UGUI_SaveLoadout()
	{
	}

	public void UGUI_EquipLoadout()
	{
	}

	public void SetGearEquipController(GearEquipController gearEquipController)
	{
	}

	public void UpdateEquippedStatus()
	{
	}

	public bool IsEquipped()
	{
		return false;
	}

	public void SetSaveable(bool saveable)
	{
	}

	public void UpdateGearSelection(bool selected, Gear gear)
	{
	}

	private void OnSelect(GearCardHolder gearIcon)
	{
	}

	private void SelectGear(Gear gear)
	{
	}

	private void DeselectGear()
	{
	}

	private void OnGearSold(Gear soldGear)
	{
	}

	private void OnGearUpdated(Gear gear)
	{
	}

	private void PopulateGearCardSlotsWithGear(List<Gear> equippedGear)
	{
	}

	private void RefreshGearPointsText()
	{
	}

	private int GetUsedGearPoints()
	{
		return 0;
	}

	private void HandleSaveLoadoutRequest(string loadoutId, List<Gear> equippedGear)
	{
	}
}
