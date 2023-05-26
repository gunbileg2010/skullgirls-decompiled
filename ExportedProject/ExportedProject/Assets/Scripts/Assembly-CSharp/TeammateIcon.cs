using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeammateIcon : MonoBehaviour
{
	[SerializeField]
	private int teammateIndex;

	[SerializeField]
	private LocalizedUGUIText nameText;

	[SerializeField]
	private LocalizedUGUIText variantNameText;

	[SerializeField]
	private UIGradient32 variantNameGradient;

	[SerializeField]
	private Outline variantNameOutline;

	[SerializeField]
	private GameObject fighterScoreParent;

	[SerializeField]
	private Text fighterScoreText;

	[SerializeField]
	private PalettizedUIImage portraitImagePalettized;

	[SerializeField]
	private Color inactiveBackgroundTint;

	[SerializeField]
	private PalettizedUIImage deadPortraitImagePalettized;

	[SerializeField]
	private Image deadPortraitBackground;

	[SerializeField]
	private Image portraitFrameImage;

	[SerializeField]
	private Image[] marqueeAccents;

	[SerializeField]
	private Image[] prestigeAccents;

	[SerializeField]
	private UIGradientMapped portraitBackgroundGradient;

	[SerializeField]
	private Image healthStateImage;

	[SerializeField]
	private Sprite[] healthStateSprites;

	[SerializeField]
	private GameObject nonInteractivePortraitGO;

	[SerializeField]
	private UIShinyEffect shinyEffect;

	[SerializeField]
	private RectTransform modifierIconsParent;

	[SerializeField]
	private Lifebar lifebar;

	[SerializeField]
	private Button button;

	[SerializeField]
	private Animation regenGlowAnimation;

	[SerializeField]
	private Image cooldownRing;

	[SerializeField]
	private Image cooldownRingFrame;

	[SerializeField]
	private GameObject queuedGlowGO;

	[SerializeField]
	private Image lockImage;

	[SerializeField]
	private ElementAffiliationUI elementalAffiliationUI;

	[SerializeField]
	private DebugFighterStatsUI debugFighterStatsUI;

	private Character myCharacter;

	private Actor myActor;

	private Actor myPointActor;

	private List<ModifierIcon> modifierIcons;

	private bool interactive;

	private bool regenEffectsPlaying;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public bool IsInteractable()
	{
		return false;
	}

	public void PopulateFromCharacterData(Character newCharacter, bool isCompetitive)
	{
	}

	public void ShowModifierIcon(Modifier modifier)
	{
	}

	public void UpdateModifierIcons()
	{
	}

	public void UpdateElementalUI()
	{
	}

	public void UpdateReactionsToEnemy(Character enemy)
	{
	}

	public void SetInteractable(bool interactive)
	{
	}

	public void SetElementalAffiliationUIActive(bool active)
	{
	}

	public void AddModifierIcon(ModifierIcon icon)
	{
	}

	public void SetStatusText(string status)
	{
	}

	public void UGUI_LifebarPressed()
	{
	}

	public Transform GetModifierParent()
	{
		return null;
	}

	private void PlayAvailableEffect()
	{
	}

	private void ToggleRegenEffects(bool active)
	{
	}

	private void OnElementChanged(object passed)
	{
	}
}
