using UnityEngine;
using UnityEngine.UI;

public class GearCard : Card
{
	[SerializeField]
	private PalettizedUIImage gearIcon;

	[SerializeField]
	private Image loadingIcon;

	[SerializeField]
	private Image[] frameImages;

	[SerializeField]
	private Sprite[] frameSprites;

	[SerializeField]
	private Material[] frameMaterials;

	[SerializeField]
	private GameObject randomIcon;

	[SerializeField]
	private GameObject levelGO;

	[SerializeField]
	private Text levelText;

	[SerializeField]
	private CharacterCardRarityElement[] levelBadgeAdaptiveElements;

	[SerializeField]
	private GameObject selectedGO;

	private GearType gearType;

	private Gear myGear;

	private GearData myGearData;

	private Character myCharacter;

	public void PopulateFromGear(Gear gear, Character character = null)
	{
	}

	public void PopulateFromGearData(GearData gearData)
	{
	}

	public void PopulateRandom()
	{
	}

	public override void Clear()
	{
	}

	public void UpdateCharacter(Character character)
	{
	}

	public void UpdateLevelFrame(Gear gearInstance)
	{
	}

	public void SetGearTypeForCard(GearType gearType)
	{
	}

	public GearType GetGearTypeForCard()
	{
		return default(GearType);
	}

	public Gear GetGear()
	{
		return null;
	}

	public void SetSelected(bool selected)
	{
	}

	public bool GetSelected()
	{
		return false;
	}

	public void ShowLevelBadge(bool show)
	{
	}

	public void UseLootDisplayMode()
	{
	}

	public void UseCollectionDisplayMode()
	{
	}

	public void SetGrayscaleAndTint(float value, Color tint)
	{
	}

	public void UGUI_CardButtonPress()
	{
	}

	private void RefreshLevel(Gear overrideGear = null)
	{
	}

	private void RefreshImage()
	{
	}

	private Palette GetPalette(out int paletteIdx)
	{
		paletteIdx = default(int);
		return null;
	}

	private void PopulateFramingElement(Image[] imageArray, Sprite[] spriteArray, Material[] materials = null)
	{
	}

	private void PopulateFramingElement(Image image, Sprite[] spriteArray, Material[] materials = null)
	{
	}
}
