using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
	private Stack<MusicPlayer> musicStack;

	private Dictionary<string, MusicPlayer> cachedMusicPlayers;

	private void Start()
	{
	}

	public MusicPlayer Play(AudioClip intro, AudioClip loop)
	{
		return null;
	}

	public void Pop(bool fadeInPrevious = true)
	{
	}

	public void Clear()
	{
	}

	public void Pause()
	{
	}

	public void Unpause()
	{
	}

	public void UpdateVolume(float volume)
	{
	}

	public void DampenMusic()
	{
	}

	public void DampenMusic(float newVolumePercent)
	{
	}

	public void UnDampenMusic()
	{
	}

	public void PlayStinger(AudioClip stinger)
	{
	}

	private IEnumerator DoPlayStinger(AudioClip stinger)
	{
		return null;
	}
}
