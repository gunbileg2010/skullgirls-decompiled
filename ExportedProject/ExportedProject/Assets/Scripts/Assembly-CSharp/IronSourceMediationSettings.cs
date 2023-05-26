using UnityEngine;

public class IronSourceMediationSettings : ScriptableObject
{
	public static readonly string IRONSOURCE_SETTINGS_ASSET_PATH;

	public string AndroidAppKey;

	public string IOSAppKey;

	public bool EnableIronsourceSDKInitAPI;

	public bool AddIronsourceSkadnetworkID;

	public bool DeclareAD_IDPermission;

	public bool EnableAdapterDebug;

	public bool EnableIntegrationHelper;
}
