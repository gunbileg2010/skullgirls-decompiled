using System;
using System.Collections.Generic;
using UnityEngine;

public class AndroidPermissionsManager : MonoBehaviour
{
	[Serializable]
	public class PermissionRequest
	{
		public AndroidDangerousPermission permission;

		public string permissionName;

		public string permissionExplication;
	}

	[SerializeField]
	protected List<PermissionRequest> defaultAppPermissions;

	protected Action<string, string, Action, Action> showInformationPopup;

	protected AndroidJavaObject _permissionsManagerPlugin;

	protected Action<bool> currentRequestCallback;

	protected PermissionRequest currentPermissionRequest;

	protected AndroidJavaObject permissionsManagerPlugin => null;

	private void OnApplicationPause(bool pause)
	{
	}

	public void SetupInformationPopup(Action<string, string, Action, Action> showInformationPopup)
	{
	}

	public void RequestDefaultPermissions(Action<bool> requestCompletedCallback)
	{
	}

	public bool HasDefaultPermissions()
	{
		return false;
	}

	protected bool HasPermission(AndroidDangerousPermission permission)
	{
		return false;
	}

	protected void RequestDefaultPermissionsRecursive(int i, bool previousResult, Action<bool> requestCompletedCallback)
	{
	}

	protected void RequestPermission(PermissionRequest permissionRequest, Action<bool> requestCallback)
	{
	}

	protected void RequestAndroidPermission(AndroidDangerousPermission permission)
	{
	}

	protected string GetPermissionString(AndroidDangerousPermission permission)
	{
		return null;
	}

	protected void ExecuteCurrentRequestCallback()
	{
	}
}
