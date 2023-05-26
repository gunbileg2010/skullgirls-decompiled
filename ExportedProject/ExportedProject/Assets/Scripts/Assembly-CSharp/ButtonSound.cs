using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
	[SerializeField]
	private UIAudioSound soundOnClick;

	[SerializeField]
	private AudioClip soundClipOverride;

	[NonSerialized]
	public bool blockSound;

	private AudioClip soundToPlay;

	private Button button;

	private Toggle toggle;

	private void Start()
	{
	}

	public void SetSoundOnClick(UIAudioSound sound)
	{
	}

	public void SetSoundClipOverride(AudioClip clip)
	{
	}

	public void PlaySound()
	{
	}

	private void OnButtonClick()
	{
	}

	private void OnToggleChanged(bool val)
	{
	}

	private void UpdateSoundToPlay()
	{
	}
}
