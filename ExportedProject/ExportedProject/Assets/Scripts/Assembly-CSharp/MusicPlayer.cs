using System.Collections;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
	private AudioSource musicPlayer1;

	private AudioSource musicPlayer2;

	private float volume;

	private void Awake()
	{
	}

	public void Play(AudioClip intro, AudioClip loop)
	{
	}

	public void SkipToLoopTime(float time)
	{
	}

	public void FadeOut(float fadeOutTime, float fadeOutToVolume = 0f)
	{
	}

	public void FadeIn(float fadeInTime, float fadeInFromVolume = 0f)
	{
	}

	public AudioClip GetIntroClip()
	{
		return null;
	}

	public AudioClip GetLoopClip()
	{
		return null;
	}

	public void Pause()
	{
	}

	public void UnPause()
	{
	}

	public void SetVolume(float updatedVolume)
	{
	}

	public float GetVolume()
	{
		return 0f;
	}

	private IEnumerator DoFade(float fadeTime, float fromVolume, float toVolume)
	{
		return null;
	}
}
