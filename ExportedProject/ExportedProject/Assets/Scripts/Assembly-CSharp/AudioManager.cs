using System.Collections;
using UnityEngine;

public class AudioManager : MonoBehaviour, IAudioManager
{
	public enum SoundType
	{
		SFX = 0,
		Music = 1,
		VO = 2
	}

	private class SoundChannel
	{
		public bool isPaused;

		public int instanceID;

		public int userCount;

		public AudioSource audioSource;

		public void Reset()
		{
		}
	}

	private enum MusicPlayState
	{
		STOPPED = 0,
		PAUSED = 1,
		PLAYING = 2,
		PLAYING_INTRO = 3
	}

	[SerializeField]
	private bool createAudioListener;

	[SerializeField]
	private int initialSfxChannels;

	private AudioListener listener;

	private AudioSource[] musicChannels;

	private int currentMusicSource;

	private int nextMusicSource;

	private float musicVolume;

	private string musicSequenceName;

	private AudioClip[] musicSequence;

	private int musicSequenceIndex;

	private bool loopMusicSequence;

	private MusicPlayState musicPlayState;

	private SoundChannel[] soundChannels;

	private static int sfxInstanceCounter;

	private float soundVolume;

	private bool applicationPaused;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void OnApplicationPause(bool paused)
	{
	}

	private void Update()
	{
	}

	public void PlayMusic(AudioClip musicClip, bool isLooped)
	{
	}

	public void PlayMusic(AudioClip musicClip, bool isLooped, float crossfadeTime)
	{
	}

	public void PlayMusicSequence(string sequenceName, AudioClip introClip, AudioClip[] musicClips, bool loopMusicClips, float crossfadeTime, bool randomTime)
	{
	}

	public void StopMusic(float fadeOutTime)
	{
	}

	public void SetMusicVolume(float volume)
	{
	}

	public void MuteMusic(bool shouldMute)
	{
	}

	public int PlaySound(AudioClip soundClip, bool isLooped)
	{
		return 0;
	}

	public int PlaySound(AudioClip soundClip, bool isLooped, bool isSharedInstance)
	{
		return 0;
	}

	public void PauseSound(int instanceID)
	{
	}

	public void ResumeSound(int instanceID)
	{
	}

	public void StopSound(int instanceID)
	{
	}

	public void StopSound(AudioClip clip)
	{
	}

	public void SetSoundPitch(int instanceID, float pitch)
	{
	}

	public void SetSoundVolume(float newSfxVolume)
	{
	}

	public void SetSoundVolume(int instanceID, float newSfxVolume)
	{
	}

	public void MuteSound(bool shouldMute)
	{
	}

	public bool IsSoundPlaying(AudioClip clip)
	{
		return false;
	}

	private IEnumerator CrossfadeMusicTracks(int musicSourceIndex, float crossfadeDuration)
	{
		return null;
	}

	private int FindFreeMusicChannel(AudioClip musicClip, bool loop)
	{
		return 0;
	}

	private SoundChannel FindFreeSoundChannel()
	{
		return null;
	}

	private bool IsSoundAlreadyPlaying(AudioClip clip, ref SoundChannel sfxInstance)
	{
		return false;
	}
}
