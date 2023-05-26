using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class FighterInfoColumn : MonoBehaviour
{
	[SerializeField]
	private LocalizedUGUIText baseCharacterNameText;

	[SerializeField]
	private UIGradient32 baseCharacterNameGradient;

	[SerializeField]
	private LocalizedUGUIText variantCharacterNameText;

	[SerializeField]
	private UIGradient32 variantCharacterNameGradient;

	[SerializeField]
	private Image sigilImage;

	[SerializeField]
	private Sprite randomSigil;

	[SerializeField]
	private GameObject fighterScoreGO;

	[SerializeField]
	private Text fighterScoreText;

	[SerializeField]
	private ElementAffiliationUI elementAffiliationUI;

	[SerializeField]
	private GearPipsUI gearPips;

	[SerializeField]
	private FighterAlertBadge alertBadge;

	[SerializeField]
	private EnergyBarUI energyBar;

	private Character myCharacter;

	private Energy energy;

	private bool canChangeSpecial;

	private Color32[] originalCharacterNameGradientColors;

	private Action<Character> detailsButtonCallback;

	private int energyRequirement;

	public ContextualPopupItem ContextualPopupItem
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Populate(Character character, Action<Character> detailsCallback = null, Action callback = null)
	{
	}

	public void ShowHideGeneralAlert(bool show)
	{
	}

	public void ShowHideEnergyAlert(bool show)
	{
	}

	public void ShowHideEnergyRefill(bool show)
	{
	}

	public void SetRandomDisplay(bool isRandom)
	{
	}

	public void SetCompetitiveDisplay()
	{
	}

	public void ShowHideEnergyUI(bool show)
	{
	}

	public void SetAllowCharacterDetails(bool allow)
	{
	}

	public void SetEnergyRequirement(int energyRequirement)
	{
	}

	public void UGUI_DetailsButtonPressed()
	{
	}

	public void UGUI_EnergyRefillButtonPressed()
	{
	}
}
