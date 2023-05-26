using UnityEngine;

public class CharacterCardXpContainer : Card
{
	[SerializeField]
	private CharacterXpDisplay characterXpDisplay;

	private CharacterCard containedCard;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Contain(CharacterCard card)
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

	private void OnLevelGainAnimationPlayed(int currentLevel)
	{
	}
}
