using UnityEngine;
using UnityEngine.UI;

public class LoadingProgressBarUI : ProgressBarUI
{
	[SerializeField]
	private Slider individualFileBar;

	[SerializeField]
	private Text individualFileProgressText;

	[SerializeField]
	private Slider tutorialSlider;

	public void SetIndividualProgress(float progress)
	{
	}

	public void SetTutorialIndicator(bool visible, float percentagePose)
	{
	}
}
