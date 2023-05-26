using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BlockbusterIntroUI : MonoBehaviour
{
	[SerializeField]
	private RectTransform filmTransform;

	[SerializeField]
	private RawImage portraitImage;

	[SerializeField]
	private Image vignette;

	private void Awake()
	{
	}

	public IEnumerator Show(Character character)
	{
		return null;
	}

	private IEnumerator FadeInVignette(float duration)
	{
		return null;
	}

	private IEnumerator FadeOutVignette(float duration)
	{
		return null;
	}
}
