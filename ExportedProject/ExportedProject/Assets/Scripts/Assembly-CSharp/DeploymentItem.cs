using System;
using UnityEngine;
using UnityEngine.UI;

public class DeploymentItem : MonoBehaviour
{
	[SerializeField]
	private PopupData deploymentDetailsPopupData;

	[SerializeField]
	private MapNodeGraphics singleMapNode;

	[SerializeField]
	private MapNodeGraphics doubleMapNode;

	[SerializeField]
	private MapNodeGraphics tripleMapNode;

	[SerializeField]
	private LocalizedUGUIText titleText;

	[SerializeField]
	private LocalizedUGUIText xpText;

	[SerializeField]
	private RewardItem rewardItem;

	[SerializeField]
	private LocalizedUGUIText durationText;

	[SerializeField]
	private AdvancedButton claimButton;

	[SerializeField]
	private Button closeButton;

	[SerializeField]
	private GameObject dailyMaxCoverGO;

	[SerializeField]
	private TimerUI dailyMaxTimer;

	private DeploymentServerData deployment;

	private DeploymentsView parentView;

	private bool allowTapping;

	public void Show(DeploymentServerData deployment, DeploymentsView parentView, Action callback = null)
	{
	}

	public void Repopulate(DeploymentServerData deployment, bool refreshDeploymentCountText = false, Action callback = null)
	{
	}

	public void Hide()
	{
	}

	public void SetDeploymentNodeGraphicsActive()
	{
	}

	public DeploymentServerData GetDeploymentServerData()
	{
		return null;
	}

	public DeploymentsView GetParentView()
	{
		return null;
	}

	public void UGUI_RefreshDeployment()
	{
	}

	public void UGUI_OpenDeploymentDetails()
	{
	}

	public void UGUI_ClaimOrAccelerateDeployment()
	{
	}

	public void ShouldAllowTapping(bool allowTapping)
	{
	}
}
