using UnityEngine;
using UnityEngine.UI;

public class DownloadPopup : SGUGUIPopup
{
	[SerializeField]
	private Graphic backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private LoadingProgressBarUI progressBarUI;

	[SerializeField]
	private HintTickerUI hintTickerUI;

	[SerializeField]
	private Button playButton;

	[SerializeField]
	private GameObject downloadSkipButtonGO;

	private float downloadTimeStarted;

	private int targetPriority;

	private int taskCount;

	private int lastReportedTasksCompleted;

	private string lastReportedStatus;

	private void Update()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void UGUI_PlayButtonPressed()
	{
	}

	public void UGUI_SkipButtonPressed()
	{
	}

	private void OnDownloadProgressChanged(float progress, float individualFileProgress, bool isDone)
	{
	}

	private void OnDownloadStatusChanged(string status)
	{
	}
}
