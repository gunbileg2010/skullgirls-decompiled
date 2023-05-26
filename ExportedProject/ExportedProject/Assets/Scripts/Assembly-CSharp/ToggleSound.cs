using UnityEngine;
using UnityEngine.UI;

public class ToggleSound : MonoBehaviour
{
	[SerializeField]
	private UIAudioSound soundOnClick;

	[SerializeField]
	private AudioClip soundClipOverride;

	private AudioClip soundToPlay;

	private Toggle toggle;

	private void Start()
	{
	}

	private void OnToggleChanged(bool isOn)
	{
	}
}
