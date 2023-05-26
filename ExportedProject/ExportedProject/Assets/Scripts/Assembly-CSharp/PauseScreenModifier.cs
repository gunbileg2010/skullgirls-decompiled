using UnityEngine;
using UnityEngine.UI;

public class PauseScreenModifier : MonoBehaviour
{
	[SerializeField]
	private LocalizedUGUIText modifierTitle;

	[SerializeField]
	private LocalizedUGUIText modifierDescription;

	[SerializeField]
	private Image modifierIcon;

	[SerializeField]
	private Sprite matchModifierIconSprite;

	[SerializeField]
	private Sprite nodeModifierIconSprite;

	[SerializeField]
	private Vector2 tooltipPivot;

	private string tooltipText;

	private ContextualPopupItem contextualPopup;

	public void Populate(string title, string description, Sprite sprite)
	{
	}

	public void PopulateFromCharacterSignatureAbility(Character character)
	{
	}

	public void PopulateFromExtraCharacterSignatureAbility(Character character, int originalFeatureCount)
	{
	}

	public void PopulateFromCharacterMarqueeAbility(Character character)
	{
	}

	public void PopulateFromFightModifier(SignatureAbility fightModifierSA)
	{
	}

	public void PopulateFromFightModifier(string title, string description)
	{
	}

	public void PopulateFromCollectibleNodeModifier(CollectibleNodeModifier collectibleNodeModifier)
	{
	}

	public void PopulateFromModifier(Modifier modifier)
	{
	}

	public void PopulateFromElementalAffiliation(Actor actor, ElementStatus affiliationStatus)
	{
	}

	public void PopulateFromCharacterAbility(CharacterAbility characterAbility)
	{
	}

	public void PopulateFromCharacterPrestigeAbility(Character character)
	{
	}

	public void SetTooltipPivot(Vector2 pivot)
	{
	}

	public void UGUI_DisplayTooltip()
	{
	}

	public void UGUI_HideTooltip()
	{
	}

	private Sprite GetModifierIconSprite(Modifier mod)
	{
		return null;
	}
}
