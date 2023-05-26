using System;
using UnityEngine;
using UnityEngine.UI;

public class DeploymentsView : MonoBehaviour
{
	[SerializeField]
	private Badge badge;

	[SerializeField]
	private LocalizedUGUIText deploymentsStartedText;

	[SerializeField]
	private UIGradient32 deploymentsStartedGradient;

	[SerializeField]
	private TimerUI dailyCooldownHiddenTimer;

	[SerializeField]
	private DeploymentItem shortDeploymentItem;

	[SerializeField]
	private DeploymentItem mediumDeploymentItem;

	[SerializeField]
	private DeploymentItem longDeploymentItem;

	[SerializeField]
	private LoadingView loadingView;

	[SerializeField]
	private Button debugClearButton;

	[SerializeField]
	private Button debugNumStartedClearButton;

	public void Refresh(Action callback = null, bool isDebugClear = false)
	{
	}

	public void RepopulateAllItems(Action callback = null)
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void ShowLoading()
	{
	}

	public void HideLoading()
	{
	}

	public void RefreshBadge()
	{
	}

	public void SetNumDeploymentsText()
	{
	}

	public void ShouldAllowTappingAllDeployments(bool allowTapping)
	{
	}

	public void UGUI_ClearButtonPressed()
	{
	}

	public void UGUI_ClearNumStartedButtonPressed()
	{
	}
}
