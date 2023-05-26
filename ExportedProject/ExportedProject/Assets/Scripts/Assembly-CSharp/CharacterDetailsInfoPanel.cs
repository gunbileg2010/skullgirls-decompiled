using UnityEngine;
using UnityEngine.UI;

public class CharacterDetailsInfoPanel : MonoBehaviour
{
	[SerializeField]
	private LocalizedUGUIText nameText;

	[SerializeField]
	private LocalizedUGUIText variantNameText;

	[SerializeField]
	private UIGradient32 wikiLinkGradient;

	[SerializeField]
	private Text fighterScoreText;

	[SerializeField]
	private ElementAffiliationUI elemetAffiliationUI;

	[SerializeField]
	private CharacterPortrait characterPortrait;

	[SerializeField]
	private LocalizedUGUIText characterQuote;

	[SerializeField]
	private LocalizedUGUIText characterDescription;

	[SerializeField]
	private LocalizedUGUIText voArtistNameText;

	[SerializeField]
	private LocalizedUGUIText levelText;

	[SerializeField]
	private Image levelProgressBar;

	[SerializeField]
	private Transform skillTreeButtonTransform;

	[SerializeField]
	private Image insigniaImage;

	[SerializeField]
	private Image skillTreeProgressBar;

	[SerializeField]
	private Image upgradeBadge;

	[SerializeField]
	private Text skillPointsText;

	[SerializeField]
	private AdvancedButton powerupButton;

	[SerializeField]
	private GameObject fullyEvolvedGO;

	[SerializeField]
	private GameObject evolutionUIAdditions;

	[SerializeField]
	private FullAbilitiesView fullAbilitiesView;

	[SerializeField]
	private ScrollRect infoScrollRect;

	private Character currentCharacter;

	public void Populate(Character character, TeamType teamType)
	{
	}

	public void Clear()
	{
	}

	public void Refresh()
	{
	}

	public void SetScrollingEnabled(bool active)
	{
	}

	public void SetSpeciaAbilitiesToggleGroupEnabled(bool active)
	{
	}

	public Transform GetSkillTreeButtonTransform()
	{
		return null;
	}

	public Transform GetExperienceContextualButtonTransform()
	{
		return null;
	}

	private void RefreshPowerUpButton()
	{
	}
}
