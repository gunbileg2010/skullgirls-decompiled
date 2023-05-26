using UnityEngine;
using UnityEngine.UI;

public class ProgressBarUI : MonoBehaviour
{
	[SerializeField]
	private Slider progressBar;

	[SerializeField]
	private Text progressText;

	[SerializeField]
	private LocalizedUGUIText statusText;

	public void SetProgress(float normalizedProgress)
	{
	}

	public void SetStatus(string status)
	{
	}
}
