using UnityEngine;
using UnityEngine.UI;

public class ImageColorEzSelfContainedAnimator : AbstractEZSelfContainedAnimator
{
	[SerializeField]
	private Color startingColor;

	[SerializeField]
	private Color targetColor;

	[SerializeField]
	private bool useAlphaOnly;

	private Color originalColor;

	private Image targetImage;

	protected override void Awake()
	{
	}

	public void Setup()
	{
	}

	private void UpdateState(float lerp)
	{
	}

	protected override EZAnimation GetAnimation()
	{
		return null;
	}

	protected override void Reset()
	{
	}
}
