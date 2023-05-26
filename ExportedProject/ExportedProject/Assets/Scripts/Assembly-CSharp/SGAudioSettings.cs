using UnityEngine;

public class SGAudioSettings : ScriptableObject
{
	public float defaultMusicVolume;

	public float defaultSfxVolume;

	public float defaultVoVolume;

	public float dampenPercent;

	public float dampenTime;

	[SerializeField]
	private AudioClip buttonPress;

	[SerializeField]
	private AudioClip back;

	[SerializeField]
	private AudioClip fight;

	[SerializeField]
	private AudioClip error;

	public AudioClip pickupCard;

	public AudioClip dropCard;

	public AudioClip[] characterLevelUpStingers;

	public AudioClip characterLevelUpSecondary;

	public AudioClip UIReward;

	public AudioClip superUIReward;

	public AudioClip meterFill;

	public AudioClip rewardItemSmall;

	public AudioClip rewardItemLarge;

	public AudioClip rewardItemDupe;

	public AudioClip IAPSuccess;

	public AudioClip relicAmbient;

	public AudioClip relicPillarShow;

	public AudioClip relicShake;

	public AudioClip relicHold;

	public AudioClip relicPlace;

	public AudioClip relicSpin;

	public AudioClip relicActivate;

	public AudioClip relicRareActivate;

	public AudioClip relicUltraRareActivate;

	public AudioClip relicExplode;

	public AudioClip relicOrbExplode;

	public AudioClip relicRewardCharacterShow;

	public AudioClip relicRewardSpecialMoveShow;

	public AudioClip relicRewardSCShow;

	public AudioClip relicRewardHCShow;

	public AudioClip tooltipShow;

	public AudioClip initialDownloadComplete;

	public AudioClip GetAudioClipForUI(UIAudioSound type)
	{
		return null;
	}

	public AudioClip GetLevelUpSoundForIndex(int idx)
	{
		return null;
	}

	public float GetMusicVolume()
	{
		return 0f;
	}
}
