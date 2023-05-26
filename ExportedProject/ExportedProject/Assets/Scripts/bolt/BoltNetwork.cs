using System;
using System.Collections.Generic;
using Bolt;
using UdpKit;
using UnityEngine;

[Documentation]
public static class BoltNetwork
{
	internal static Map<Guid, UdpSession> _sessionList;

	internal static Dictionary<Guid, uint> _sessionListTimeout;

	public static IEnumerable<BoltConnection> Connections => null;

	[Obsolete]
	public static IEnumerable<BoltConnection> connections => null;

	public static IEnumerable<BoltConnection> Clients => null;

	[Obsolete]
	public static IEnumerable<BoltConnection> clients => null;

	public static AsyncOperation CurrentAsyncOperation => null;

	[Obsolete]
	public static AsyncOperation currentAsyncOperation => null;

	public static IEnumerable<BoltEntity> Entities => null;

	[Obsolete]
	public static IEnumerable<BoltEntity> entities => null;

	public static int Frame => 0;

	[Obsolete]
	public static int frame => 0;

	[Obsolete]
	public static float FrameAlpha => 0f;

	[Obsolete]
	public static float frameAlpha => 0f;

	[Obsolete]
	public static float FrameBeginTime => 0f;

	[Obsolete]
	public static float frameBeginTime => 0f;

	public static float FrameDeltaTime => 0f;

	[Obsolete]
	public static float frameDeltaTime => 0f;

	public static int FramesPerSecond => 0;

	[Obsolete]
	public static int framesPerSecond => 0;

	public static GameObject GlobalObject => null;

	[Obsolete]
	public static GameObject globalObject => null;

	public static bool IsConnected => false;

	[Obsolete]
	public static bool isConnected => false;

	public static bool IsClient => false;

	[Obsolete]
	public static bool isClient => false;

	public static bool IsDebugMode => false;

	[Obsolete]
	public static bool isDebugMode => false;

	public static bool IsRunning => false;

	[Obsolete]
	public static bool isRunning => false;

	public static bool IsServer => false;

	[Obsolete]
	public static bool isServer => false;

	public static bool IsSinglePlayer => false;

	public static int MaxConnections => 0;

	[Obsolete]
	public static int maxConnections => 0;

	public static IEnumerable<BoltEntity> SceneObjects => null;

	public static ScopeMode ScopeMode => default(ScopeMode);

	[Obsolete]
	public static ScopeMode scopeMode => default(ScopeMode);

	public static BoltConnection Server => null;

	[Obsolete]
	public static BoltConnection server => null;

	public static int ServerFrame => 0;

	[Obsolete]
	public static int serverFrame => 0;

	public static float ServerTime => 0f;

	[Obsolete]
	public static float serverTime => 0f;

	public static Map<Guid, UdpSession> SessionList => null;

	public static float Time => 0f;

	[Obsolete]
	public static float time => 0f;

	public static UdpSocket UdpSocket => null;

	public static Version Version => null;

	public static string CurrentVersion => null;

	public static string VersionInfo => null;

	public static string VersionConfiguration => null;

	public static void AddGlobalEventListener(MonoBehaviour mb)
	{
	}

	public static void AddGlobalEventCallback<T>(Action<T> callback) where T : Bolt.Event
	{
	}

	public static void RemoveGlobalEventListener(MonoBehaviour mb)
	{
	}

	public static void RemoveGlobalEventCallback<T>(Action<T> callback) where T : Bolt.Event
	{
	}

	public static void EnableLanBroadcast(ushort port = 60000)
	{
	}

	public static void DisableLanBroadcast()
	{
	}

	public static void RegisterTokenClass<T>() where T : class, IProtocolToken, new()
	{
	}

	public static void SetEventFilter(IEventFilter filter)
	{
	}

	public static void SetNetworkSimulation(float loss, int pingMin, int pingMax)
	{
	}

	public static void UpdateSessionList(Map<Guid, UdpSession> sessions)
	{
	}

	public static void UpdateSceneObjectsLookup()
	{
	}

	internal static void VerifyIsRunning()
	{
	}

	public static void Accept(UdpEndPoint endpoint)
	{
	}

	public static void Accept(UdpEndPoint endpoint, IProtocolToken acceptToken)
	{
	}

	internal static void Connect(UdpEndPoint endpoint, IProtocolToken token = null)
	{
	}

	public static void Connect(UdpSession session, IProtocolToken token = null)
	{
	}

	public static void Connect(ushort port)
	{
	}

	public static UdpChannelName CreateStreamChannel(string name, UdpChannelMode mode, int priority)
	{
		return default(UdpChannelName);
	}

	public static void LoadScene(string scene)
	{
	}

	public static void LoadScene(string scene, IProtocolToken token)
	{
	}

	public static void Refuse(UdpEndPoint endpoint)
	{
	}

	public static void Refuse(UdpEndPoint endpoint, IProtocolToken token)
	{
	}

	public static void SetServerInfo(string serverName, IProtocolToken token)
	{
	}

	public static void SetDedicatedServerInfo(string serverName, IProtocolToken token)
	{
	}

	public static void Shutdown()
	{
	}

	public static void ShutdownImmediate()
	{
	}

	public static Vector3 PositionAtFrame(BoltHitboxBody hitboxBody, int frame)
	{
		return default(Vector3);
	}

	public static BoltPhysicsHits RaycastAll(Ray ray)
	{
		return null;
	}

	public static BoltPhysicsHits RaycastAll(Ray ray, int frame)
	{
		return null;
	}

	public static BoltPhysicsHits OverlapSphereAll(Vector3 origin, float radius)
	{
		return null;
	}

	public static BoltPhysicsHits OverlapSphereAll(Vector3 origin, float radius, int frame)
	{
		return null;
	}

	public static GameObject Attach(GameObject gameObject)
	{
		return null;
	}

	public static GameObject Attach(GameObject gameObject, IProtocolToken token)
	{
		return null;
	}

	public static void Detach(GameObject gameObject)
	{
	}

	public static void Detach(GameObject gameObject, IProtocolToken token)
	{
	}

	public static void Destroy(GameObject gameObject)
	{
	}

	public static void Destroy(GameObject gameObject, IProtocolToken token)
	{
	}

	public static BoltEntity FindEntity(NetworkId id)
	{
		return null;
	}

	public static BoltEntity Instantiate(GameObject prefab)
	{
		return null;
	}

	public static BoltEntity Instantiate(GameObject prefab, IProtocolToken token)
	{
		return null;
	}

	public static BoltEntity Instantiate(GameObject prefab, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	public static BoltEntity Instantiate(GameObject prefab, IProtocolToken token, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	public static BoltEntity Instantiate(PrefabId prefabId)
	{
		return null;
	}

	public static BoltEntity Instantiate(PrefabId prefabId, IProtocolToken token)
	{
		return null;
	}

	public static BoltEntity Instantiate(PrefabId prefabId, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	public static BoltEntity Instantiate(PrefabId prefabId, IProtocolToken token, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	public static void PreLoadPrefabDatabase()
	{
	}

	public static void SetPrefabPool(IPrefabPool pool)
	{
	}

	public static void SetCanReceiveEntities(bool canReceiveEntities)
	{
	}
}
