using Bolt;
using UnityEngine;
using udpkit.platform.photon;

public class BoltRuntimeSettings : ScriptableObject
{
	private static BoltRuntimeSettings _instance;

	[SerializeField]
	internal BoltConfig _config;

	[SerializeField]
	public int debugClientCount;

	[SerializeField]
	public int debugStartPort;

	[SerializeField]
	public string debugStartMapName;

	[SerializeField]
	public bool debugPlayAsServer;

	[SerializeField]
	public bool showDebugInfo;

	[SerializeField]
	public bool overrideTimeScale;

	[SerializeField]
	public bool logUncaughtExceptions;

	[SerializeField]
	public BoltEditorStartMode debugEditorMode;

	[SerializeField]
	public KeyCode consoleToggleKey;

	[SerializeField]
	public bool consoleVisibleByDefault;

	[SerializeField]
	public int compilationWarnLevel;

	[SerializeField]
	public int editorSkin;

	[SerializeField]
	public bool scopeModeHideWarningInGui;

	[SerializeField]
	public bool showHelpButtons;

	[SerializeField]
	public string masterServerGameId;

	[SerializeField]
	public bool showBoltEntityHints;

	[SerializeField]
	public bool serializeProjectAsText;

	[SerializeField]
	public string photonAppId;

	[SerializeField]
	public bool photonUsePunch;

	[SerializeField]
	public int photonCloudRegionIndex;

	[SerializeField]
	public BoltPrefabInstantiateMode instantiateMode;

	[SerializeField]
	public QueryComponentOptionsGlobal globalEntityBehaviourQueryOption;

	[SerializeField]
	public QueryComponentOptionsGlobal globalEntityPriorityCalculatorQueryOption;

	[SerializeField]
	public QueryComponentOptionsGlobal globalEntityReplicationFilterQueryOption;

	[SerializeField]
	public int a2sServerPort;

	[SerializeField]
	public bool enableA2sServer;

	[SerializeField]
	public float RoomUpdateRate;

	[SerializeField]
	public float RoomCreateTimeout;

	[SerializeField]
	public float RoomJoinTimeout;

	[SerializeField]
	public bool enableClientMetrics;

	public static BoltRuntimeSettings instance => null;

	public static string[] photonCloudRegions => null;

	public static string[] photonCloudRegionsId => null;

	public BoltConfig GetConfigCopy()
	{
		return null;
	}

	public void UpdateBestRegion(PhotonRegion newRegion)
	{
	}
}
