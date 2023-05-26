using System;
using System.Collections;
using UnityEngine;

public class MaintenanceModeManager : MonoBehaviour
{
	[SerializeField]
	private PopupData maintenanceModePopupData;

	[SerializeField]
	private bool forceMaintenance;

	[SerializeField]
	private bool whitelistEditorUsers;

	private const string kLocalFileName = "maintenanceMode.json";

	private MaintenanceModeInfo maintenanceModeInfo;

	private bool requestInProgress;

	private Action<bool, bool> updateFromServerCallbacks;

	private void Start()
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	public bool IsInMaintenanceMode()
	{
		return false;
	}

	public void RefreshFromServer(Action<bool, bool> callback)
	{
	}

	public void InvalidateServerData()
	{
	}

	public void ShowMaintenancePopup(Action retryCallback)
	{
	}

	public bool IsWhitelistUser()
	{
		return false;
	}

	public void RedirectIfNeedBe()
	{
	}

	private IEnumerator RetrieveMaintenanceFile(Action<bool, bool> callback)
	{
		return null;
	}
}
