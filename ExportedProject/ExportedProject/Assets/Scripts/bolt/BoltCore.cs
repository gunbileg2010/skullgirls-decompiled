using System;
using System.Collections.Generic;
using System.Diagnostics;
using Bolt;
using UdpKit;
using UnityEngine;

internal static class BoltCore
{
	internal static UdpSocket _udpSocket;

	internal static UdpPlatform _udpPlatform;

	internal static string _autoloadScene;

	internal static Stopwatch _timer;

	internal static Stopwatch _timer2;

	internal static Stopwatch _timer3;

	internal static SceneLoadState _localSceneLoading;

	internal static bool _canReceiveEntities;

	internal static IPrefabPool PrefabPool;

	internal static IEventFilter EventFilter;

	internal static int _frame;

	internal static BoltNetworkModes _mode;

	internal static BoltConfig _config;

	internal static UdpConfig _udpConfig;

	internal static BoltDoubleList<Entity> _entitiesOK;

	internal static BoltDoubleList<Entity> _entitiesFZ;

	internal static LinkedList<BoltConnection> _connections;

	internal static EventDispatcher _globalEventDispatcher;

	internal static Dictionary<UniqueId, BoltEntity> _sceneObjects;

	internal static GameObject _globalControlObject;

	internal static GameObject _globalBehaviourObject;

	internal static List<STuple<BoltGlobalBehaviourAttribute, Type>> _globalBehaviours;

	internal static Func<GameObject, Vector3, Quaternion, GameObject> _instantiate;

	internal static Action<GameObject> _destroy;

	public static TimeSpan SendTime;

	public static TimeSpan AutoscopeTime;

	public static TimeSpan PollNetworkTime;

	public static TimeSpan InvokeRemoteSceneCallbacksTime;

	public static TimeSpan AdjustEstimatedRemoteFramesTime;

	public static TimeSpan StepNonControlledRemoteEntitiesTime;

	public static TimeSpan SimulateLocalAndControlledEntitiesTime;

	public static TimeSpan DispatchAllEventsTime;

	private static List<Entity> FreezeProxyTempList;

	internal static IEnumerable<Entity> _entities => null;

	public static bool IsDebugMode => false;

	public static bool IsCloud => false;

	public static AsyncOperation currentAsyncOperation => null;

	public static int loadedScene => 0;

	public static string loadedSceneName => null;

	public static GameObject globalObject => null;

	public static IEnumerable<BoltEntity> entities => null;

	public static IEnumerable<BoltConnection> connections => null;

	public static IEnumerable<BoltConnection> clients => null;

	public static BoltConnection server => null;

	public static int frame => 0;

	public static int framesPerSecond => 0;

	public static int serverFrame => 0;

	public static float serverTime => 0f;

	public static float time => 0f;

	public static float frameBeginTime => 0f;

	public static float frameDeltaTime => 0f;

	public static float frameAlpha => 0f;

	public static bool isClient => false;

	public static bool isServer => false;

	internal static int localSendRate => 0;

	internal static int remoteSendRate => 0;

	internal static int localInterpolationDelay => 0;

	internal static int localInterpolationDelayMin => 0;

	internal static int localInterpolationDelayMax => 0;

	internal static bool hasSocket => false;

	public static void Destroy(BoltEntity entity, IProtocolToken detachToken)
	{
	}

	internal static void DestroyForce(Entity entity)
	{
	}

	internal static bool CanClientInstantiate(BoltEntity entity)
	{
		return false;
	}

	internal static BoltEntity Instantiate(PrefabId prefabId, TypeId serializerId, Vector3 position, Quaternion rotation, InstantiateFlags instanceFlags, BoltConnection controller, IProtocolToken attachToken)
	{
		return null;
	}

	internal static GameObject Attach(GameObject gameObject, EntityFlags flags)
	{
		return null;
	}

	internal static GameObject Attach(GameObject gameObject, EntityFlags flags, IProtocolToken attachToken)
	{
		return null;
	}

	internal static GameObject Attach(GameObject gameObject, TypeId serializerId, EntityFlags flags, IProtocolToken attachToken)
	{
		return null;
	}

	public static void Detach(BoltEntity entity, IProtocolToken detachToken)
	{
	}

	public static Entity FindEntity(NetworkId id)
	{
		return null;
	}

	public static void LoadScene(int index, IProtocolToken token)
	{
	}

	internal static void LoadSceneInternal(SceneLoadState loading)
	{
	}

	public static void Shutdown(UdpConnectionDisconnectReason disconnectReason = UdpConnectionDisconnectReason.Disconnected)
	{
	}

	public static void Connect(UdpEndPoint endpoint, IProtocolToken token)
	{
	}

	public static void Connect(UdpSession session, IProtocolToken token)
	{
	}

	public static void SetServerInfo(string serverName, bool dedicated, IProtocolToken token)
	{
	}

	public static void EnableLanBroadcast(UdpIPv4Address local, UdpIPv4Address broadcast, ushort port)
	{
	}

	public static void DisableLanBroadcast()
	{
	}

	private static void AdjustEstimatedRemoteFrames()
	{
	}

	private static void StepNonControlledRemoteEntities()
	{
	}

	private static void PollNetwork()
	{
	}

	private static void Udp_SessionConnectFailed(UdpEventSessionConnectFailed ev)
	{
	}

	private static void Udp_SessionCreated(UdpKit.UdpEventSessionCreated ev)
	{
	}

	private static void Udp_SessionListUpdated(UdpEventSessionListUpdated ev)
	{
	}

	private static void Udp_StreamDataReceived(UdpEvent ev)
	{
	}

	private static void Udp_PacketReceived(UdpEvent ev)
	{
	}

	private static void Udp_PacketDelivered(UdpEvent ev)
	{
	}

	private static void Udp_PacketLost(UdpEvent ev)
	{
	}

	private static void Udp_ConnectAttempt(UdpEventConnectAttempt ev)
	{
	}

	private static void Udp_SocketStartupFailed(UdpEventStartFailed ev)
	{
	}

	private static void Udp_SocketStartupDone(UdpEventStartDone ev)
	{
	}

	private static void Udp_ConnectFailed(UdpEventConnectFailed ev)
	{
	}

	private static void Udp_ConnectRefused(UdpEventConnectRefused ev)
	{
	}

	private static void Udp_ConnectRequest(UdpEventConnectRequest ev)
	{
	}

	public static void AcceptConnection(UdpEndPoint endpoint, object userToken, IProtocolToken acceptToken)
	{
	}

	public static void RefuseConnection(UdpEndPoint endpoint, IProtocolToken token)
	{
	}

	internal static void Send()
	{
	}

	internal static void Poll()
	{
	}

	internal static void SetSessionList(Map<Guid, UdpSession> sessions)
	{
	}

	internal static void FreezeProxies()
	{
	}

	private static void InvokeRemoteSceneCallbacks()
	{
	}

	private static void Udp_Connected(UdpConnection udp)
	{
	}

	private static void Udp_Disconnect(UdpConnection udp)
	{
	}

	internal static void UpdateActiveGlobalBehaviours(int index)
	{
	}

	private static Component CreateGlobalBehaviour(Type t)
	{
		return null;
	}

	private static void DeleteGlobalBehaviour(Type t)
	{
	}

	private static void UnityLogCallback(string condition, string stackTrace, LogType type)
	{
	}

	internal static void Initialize(BoltNetworkModes mode, UdpEndPoint endpoint, BoltConfig config, UdpPlatform udpPlatform, string autoloadscene)
	{
	}

	private static void UdpLogWriter(uint level, string message)
	{
	}

	internal static void SceneLoadBegin(SceneLoadState state)
	{
	}

	internal static void SceneLoadDone(SceneLoadState state)
	{
	}

	internal static void UpdateSceneObjectsLookup()
	{
	}

	internal static GameObject FindSceneObject(UniqueId uniqueId)
	{
		return null;
	}

	internal static UdpPacket AllocateUdpPacket()
	{
		return null;
	}

	internal static UdpChannelName CreateStreamChannel(string name, UdpChannelMode mode, int priority)
	{
		return default(UdpChannelName);
	}

	internal static void Update()
	{
	}

	private static void CreateUdpConfig(BoltConfig config)
	{
	}

	private static void CreateBoltBehaviourObject()
	{
	}

	private static void ResetIdAllocator(BoltNetworkModes mode)
	{
	}

	internal static void BeginStart(ControlCommandStart cmd)
	{
	}

	internal static void ShutdownImmediate(UdpConnectionDisconnectReason disconnectReason = UdpConnectionDisconnectReason.Disconnected)
	{
	}

	internal static void BeginShutdown(ControlCommandShutdown cmd)
	{
	}
}
