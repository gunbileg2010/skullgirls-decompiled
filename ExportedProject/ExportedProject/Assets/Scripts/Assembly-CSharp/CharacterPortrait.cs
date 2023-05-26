using System;
using UnityEngine;
using UnityEngine.UI;

public class CharacterPortrait : MonoBehaviour
{
	[SerializeField]
	private PalettizedUIImage characterImage;

	[SerializeField]
	private UIGradientMapped characterGradientBackground;

	[SerializeField]
	private GameObject randomCharacterGO;

	[SerializeField]
	private Image frameImage;

	[SerializeField]
	private Image[] marqueeAccents;

	[SerializeField]
	private Image[] prestigeAccents;

	[SerializeField]
	private Image[] bossWings;

	[SerializeField]
	private GameObject fighterScoreGO;

	[SerializeField]
	private LocalizedUGUIText fighterScoreText;

	[SerializeField]
	private GameObject glowGO;

	[SerializeField]
	private Graphic touchable;

	[SerializeField]
	private CharacterCardRarityElement[] skullTierElements;

	[SerializeField]
	private UIShinyEffect uIShinyEffect;

	private RarityTier rarityTier;

	private Element element;

	private Character character;

	private Action<CharacterPortrait> selectCallback;

	public void Populate(Character character)
	{
	}

	public void Populate(XsCharacter xsCharacter)
	{
	}

	public void Populate(VariantCharacterData variantData, bool isRandom = false)
	{
	}

	public void Populate(RarityTier rarityTier, Element element, bool isRandom)
	{
	}

	public void Clear()
	{
	}

	public void RefreshFrameMaterial(Material overrideMaterial = null)
	{
	}

	public void ShowBossWings(bool show, bool dim)
	{
	}

	public void ShowMarqueeAccents(bool show)
	{
	}

	public void ShowPrestigeAccents(bool show)
	{
	}

	public void ShowFighterScore(bool show, int score = 0)
	{
	}

	public void ShowGlow(bool show)
	{
	}

	public void ShowRarityTierSkulls(bool show)
	{
	}

	public void SetIsDarkened(bool isDark)
	{
	}

	public void ShowShinyVisuals(bool show, Element? elementOverride = null)
	{
	}

	public Character GetCharacter()
	{
		return null;
	}

	public void SetClickCallback(Action<CharacterPortrait> callback)
	{
	}

	public void UGUI_PortraitPressed()
	{
	}

	public void PlayShinyRewardBurst(Element element)
	{
	}

	private void SetCharacterImageAndGradient(VariantCharacterData variantData, bool isRandom)
	{
	}

	private void ShowFrameAccents(Image[] accents, bool show, bool dim)
	{
	}
}
