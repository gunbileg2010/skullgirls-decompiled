using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GearLoadoutsPanel : MonoBehaviour
{
	[SerializeField]
	private GearEquipController gearEquipController;

	[SerializeField]
	private GearLoadoutView loadoutPrototype;

	[SerializeField]
	private AdvancedButton statsButton;

	[SerializeField]
	private CharacterDetailsStatsPanel statsPopup;

	[SerializeField]
	private LocalizedUGUIText headerText;

	[SerializeField]
	private Image headerSigil;

	[SerializeField]
	private LoadingView loadingView;

	private List<GearLoadoutView> loadouts;

	private GearLoadoutView selectedLoadout;

	private Character character;

	private Character statsDummyCharacter;

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public void Populate(Character character)
	{
	}

	public void Cleanup()
	{
	}

	public void ToggleStatsPopup()
	{
	}

	public void ResetStatsDummyCharacter()
	{
	}

	public void ChangeVisibility(bool visible)
	{
	}

	public void ChangeStatsPopupVisibility(bool visible)
	{
	}

	public void UpdateLoadoutsGearSelection(bool selected, Gear gear = null)
	{
	}

	public void GearLoadoutPressed(GearLoadoutView gearLoadout)
	{
	}

	public void UpdateLoadoutsSaveableStatus()
	{
	}

	public bool AreStatsShowing()
	{
		return false;
	}

	public void PopulateStatsWithSelectedGearLoadout()
	{
	}

	public void UpdateEquippedAndSaveableLoadouts()
	{
	}

	public void UpdateGlobalGearSelection(bool selected, Gear gear = null)
	{
	}

	public bool IsLoadoutEquipped()
	{
		return false;
	}

	private void GetAndPopulateGearLoadouts()
	{
	}

	private void PopulateGearLoadouts(List<GearLoadout> gearLoadouts)
	{
	}

	private void CreateDummyCharacterIfMissing()
	{
	}

	private void ResetDummyCharactersGears()
	{
	}

	private void SetDummyCharactersGears(List<Gear> newGears)
	{
	}

	private void SetUpBackButtonCallback(bool clear)
	{
	}
}
