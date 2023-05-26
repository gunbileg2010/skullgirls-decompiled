using System;
using UnityEngine;

public class LoadingView : MonoBehaviour
{
	[SerializeField]
	private GameObject loadingGO;

	[SerializeField]
	private LocalizedUGUIText messageText;

	[SerializeField]
	private AdvancedButton retryButton;

	private Action retryCallback;

	public void ShowLoading()
	{
	}

	public void ShowMessageAndRetry(string message, string retryText, Action retryCallback)
	{
	}

	public void HideAll()
	{
	}

	public void UGUI_RetryButtonPressed()
	{
	}

	private void ShowMessageAndRetryInternal(string message, string retryText, Action retryCallback)
	{
	}
}
