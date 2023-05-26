using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CharacterXpDisplay : MonoBehaviour
{
	[SerializeField]
	private float fillExperienceBarDuration;

	[SerializeField]
	private LocalizedUGUIText gainedExperienceText;

	[SerializeField]
	private Image experienceProgressBar;

	[SerializeField]
	private Image experienceProgressBarActive;

	[SerializeField]
	private CanvasGroup experienceCanvasGroup;

	[SerializeField]
	private CanvasGroup levelUpCanvasGroup;

	[SerializeField]
	private CurrencyDisplayUI skillPointGainUI;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private string maxLevelLocKey;

	private CharacterCard characterCard;

	private Coroutine gainExperienceCoroutine;

	private EZAnimateFloat xpBarFillAnim;

	private EZAnimateFloat fadeInAnim;

	private AudioClip levelUpStinger;

	private bool hasLeveledUpBefore;

	public event Action<int> LevelGainAnimationPlayed
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Setup(CharacterCard characterCard)
	{
	}

	public Coroutine GainExperience(long experienceGained, float fromLevel, float toLevel)
	{
		return null;
	}

	public void SetLevelUpSound(AudioClip levelUpSound)
	{
	}

	public void StopAllAnimations()
	{
	}

	private void ShowLevelCapMessage()
	{
	}

	private IEnumerator DoGainExperience(long experienceGained, float fromLevel, float toLevel)
	{
		return null;
	}

	private void SetXpLabel(long xp)
	{
	}
}
