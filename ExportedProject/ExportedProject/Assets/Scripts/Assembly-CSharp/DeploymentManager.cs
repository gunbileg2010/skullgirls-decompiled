using System;
using System.Collections.Generic;

public class DeploymentManager : MonoSingleton<DeploymentManager>
{
	private DeploymentServerData shortDeployment;

	private DeploymentServerData mediumDeployment;

	private DeploymentServerData longDeployment;

	private Price refreshCost;

	private Price shortHurryUpMaxCost;

	private Price mediumHurryUpMaxCost;

	private Price longHurryUpMaxCost;

	private int numberOfDeploymentsStartedToday;

	private int maxNumberOfDeploymentsPerDay;

	private long deploymentResetDate;

	private double fighterScoreExponent;

	private DeploymentServerData dynamicPriceDeployment;

	private Price cachedHurryUpPrice;

	private int numberOfDeploymentsRefreshed;

	public Action DeploymentsUpdated;

	private void Start()
	{
	}

	public void DeserialzeDeploymentServerDataList(List<object> data)
	{
	}

	public void DeserializeDeploymentServerData(Dictionary<string, object> data)
	{
	}

	public DeploymentServerData GetDeploymentServerData(DeploymentServerData.DeploymentDurationCategory durationCategory)
	{
		return null;
	}

	public List<string> GetAllCharacterIdsOnDeployment()
	{
		return null;
	}

	public void HurryUpDeploymentForCharacter(Character character, Action<DeploymentServerData> successCallback)
	{
	}

	public void ClaimOrAccelerateDeployment(DeploymentServerData deployment, string hurryUpLocKey, Action<DeploymentServerData> successCallback, Action showLoadingAction, Action hideLoadingAction, bool withCompletedConfirmation = false)
	{
	}

	public Price GetRefreshCost()
	{
		return null;
	}

	public Price GetHurryUpCost(DeploymentServerData.DeploymentDurationCategory durationCategory)
	{
		return null;
	}

	public int GetNumberOfDeploymentsStartedToday()
	{
		return 0;
	}

	public void SetNumberOfDeploymentsStartedToday(int numberOfDeploymentsStartedToday)
	{
	}

	public int GetMaxNumberOfDeploymentsPerDay()
	{
		return 0;
	}

	public long GetDeploymentResetDate()
	{
		return 0L;
	}

	public bool ReachedMaximumDeployments()
	{
		return false;
	}

	public void SetNumberOfDeploymentsRefreshed(int numberOfDeploymentsRefreshed)
	{
	}

	public double GetFighterScoreExponenet()
	{
		return 0.0;
	}

	public int GetDeploymentNotifCount()
	{
		return 0;
	}

	public void MarkDeplomentNotifsAsSeen()
	{
	}

	public long GetNextDeploymentCompletionDate()
	{
		return 0L;
	}

	public bool GetIsCharacterUsedInDeployment(Character character)
	{
		return false;
	}

	private void FindDeploymentAndHurryUp(Character character, Action<DeploymentServerData> successCallback)
	{
	}

	private void FireDeploymentClaimRequest(DeploymentServerData deployment, bool hurryUp, Action<DeploymentServerData> successCallback, Action<ClaimDeploymentRequest> failureCallback, Action showLoadingAction, Action hideLoadingAction)
	{
	}

	private void UpdateHurryUpPrice(CurrencyDisplayUI display)
	{
	}

	private Price GetCurrentHurryUpPrice()
	{
		return null;
	}

	private void OnLoggedIn(AuthenticateRequest authRequest)
	{
	}

	public DeploymentManager()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
