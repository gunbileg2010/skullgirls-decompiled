using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ActManager : MonoBehaviour
{
	[SerializeField]
	private GameContentSet[] actSets;

	[SerializeField]
	private Act[] acts;

	[SerializeField]
	private GameContentSet[] ltaActSets;

	[SerializeField]
	private List<Act> ltaEventActs;

	private bool needToRefreshCampaignActs;

	private List<string> availableCampaignActGuids;

	private Dictionary<string, ActServerData> actProgresses;

	public event Action CampaignActsRefreshed
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Start()
	{
	}

	public GameContentSet[] GetCampaignActSets()
	{
		return null;
	}

	public Act[] GetCampaignActs()
	{
		return null;
	}

	public GameContentSet GetCampaignActSetForAct(Act act)
	{
		return null;
	}

	public List<Act> GetLimitedTimeActs()
	{
		return null;
	}

	public GameContentSet GetLTAActSetForAct(Act act)
	{
		return null;
	}

	public Act GetActByGuid(string actGuid)
	{
		return null;
	}

	public Act[] GetDialogueTestActs()
	{
		return null;
	}

	public void RefreshCampaignActsFromServer(Action<Act> actUpdatedCallback, Action<bool, NetworkRequest> finishCallback)
	{
	}

	public bool IsCampaignActAvailable(string guid)
	{
		return false;
	}

	public void RefreshActProgressFromServer(List<string> actGuids, List<string> eventInstanceIds, Action<Act> actUpdatedCallback, Action<bool, NetworkRequest> finishCallback)
	{
	}

	public ActServerData GetActServerData(string actGuid)
	{
		return null;
	}

	private void OnLoginSucceeded(AuthenticateRequest authorizeRequest)
	{
	}

	private void OnLoggedOut()
	{
	}
}
