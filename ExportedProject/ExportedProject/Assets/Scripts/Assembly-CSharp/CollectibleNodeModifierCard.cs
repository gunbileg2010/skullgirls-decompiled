using UnityEngine;
using UnityEngine.UI;

public class CollectibleNodeModifierCard : Card
{
	[SerializeField]
	private Image mainIcon;

	[SerializeField]
	private Image secondaryIcon;

	[SerializeField]
	private Image frame;

	[SerializeField]
	private GameObject randomIcon;

	[SerializeField]
	private LocalizedUGUIText nameText;

	[SerializeField]
	private UIGradient32 nameGradient;

	[SerializeField]
	private GameObject levelGO;

	[SerializeField]
	private Text levelText;

	[SerializeField]
	private CharacterCardRarityElement[] levelBadgeAdaptiveElements;

	[SerializeField]
	private GameObject inUseBanner;

	[SerializeField]
	private GameObject selectedGO;

	private CollectibleNodeModifier nodeModifier;

	private CollectibleNodeModifierData nodeModifierData;

	private BaseCharacterData characterConstraint;

	private Element elementConstraint;

	public void PopulateFromCollectibleNodeModifier(CollectibleNodeModifier nodeModifier)
	{
	}

	public void PopulateFromLoot(Loot loot)
	{
	}

	public void PopulateFromCollectibleNodeModifierData(CollectibleNodeModifierData nodeModifierData)
	{
	}

	public void PopulateRandom()
	{
	}

	public void UpdateLevelFrame(CollectibleNodeModifier nodeModifierInstance)
	{
	}

	public override void Clear()
	{
	}

	public CollectibleNodeModifier GetCollectibleNodeModifier()
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

	public void ShowName(bool show)
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

	public void SetInUseVisibile(bool visible)
	{
	}

	public void UGUI_CardButtonPress(bool wasLongPressed = false)
	{
	}

	public void RefreshLevel()
	{
	}

	private void RefreshInstanceData()
	{
	}

	private void RefreshImage()
	{
	}

	private void RefreshConstraintImage()
	{
	}

	private Sprite GetConstraintSprite()
	{
		return null;
	}
}
