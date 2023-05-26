using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using HVS.Logger;

public static class GGPO
{
	public class GGPOPlayer
	{
		public GGPOPlayerState state;

		public bool isLocal;

		public int connectProgress;

		public int playerNumber;

		public int handle;
	}

	public struct GGPORemote
	{
		public string ipAddress;

		public ushort port;
	}

	public enum GGPOEventCode
	{
		GGPO_EVENTCODE_CONNECTED_TO_PEER = 1000,
		GGPO_EVENTCODE_SYNCHRONIZING_WITH_PEER = 1001,
		GGPO_EVENTCODE_SYNCHRONIZED_WITH_PEER = 1002,
		GGPO_EVENTCODE_RUNNING = 1003,
		GGPO_EVENTCODE_DISCONNECTED_FROM_PEER = 1004,
		GGPO_EVENTCODE_TIMESYNC = 1005,
		GGPO_EVENTCODE_CONNECTION_INTERRUPTED = 1006,
		GGPO_EVENTCODE_CONNECTION_RESUMED = 1007
	}

	public struct GGPONewtorkStatsNetwork
	{
		public int send_queue_len;

		public int recv_queue_len;

		public int ping;

		public int kbps_sent;
	}

	public struct GGPONewtorkStatsTimeSync
	{
		public int local_frames_behind;

		public int remote_frames_behind;
	}

	public struct GGPONetworkStats
	{
		public GGPONewtorkStatsNetwork network;

		public GGPONewtorkStatsTimeSync timesync;
	}

	public struct GGPOEvent
	{
		public GGPOEventCode code;

		public GGPOEventDataUnion u;
	}

	public struct GGPOEventDataPlayerHandle
	{
		public int player;
	}

	public struct GGPOEventDataPlayerHandleInt
	{
		public int player;

		public int val;
	}

	public struct GGPOEventDataSyncing
	{
		public int player;

		public int count;

		public int total;
	}

	public struct GGPOEventDataTimeSync
	{
		public int framesAhead;
	}

	[StructLayout(2)]
	public struct GGPOEventDataUnion
	{
		[FieldOffset(0)]
		public GGPOEventDataPlayerHandle connected;

		[FieldOffset(0)]
		public GGPOEventDataSyncing synchronizing;

		[FieldOffset(0)]
		public GGPOEventDataPlayerHandle synchronized;

		[FieldOffset(0)]
		public GGPOEventDataPlayerHandle disconnected;

		[FieldOffset(0)]
		public GGPOEventDataTimeSync timesync;

		[FieldOffset(0)]
		public GGPOEventDataPlayerHandleInt connection_interrupted;

		[FieldOffset(0)]
		public GGPOEventDataPlayerHandle connection_resumed;
	}

	public delegate byte[] SaveGameStateDel(ref int size, ref int checksum);

	public delegate void LoadGameStateDel(BinaryReader reader);

	public delegate void AdvanceFrameDel();

	public delegate void OnEventDel(GGPOEvent eventInfo);

	public delegate void SendDel(byte[] bytes, int length);

	public const int kGGPODefaultFrameDelay = 8;

	public static bool runningSyncTest;

	private static IntPtr ggpoPtr;

	private static IntPtr ggpo;

	private static IntPtr socketTransport;

	private static IntPtr proxyTransport;

	private static GGPOBinding.SessionCallbacks callbacks;

	private static List<GGPOPlayer> players;

	private static SaveGameStateDel SaveGameStateCallback;

	private static LoadGameStateDel LoadGameStateCallback;

	private static AdvanceFrameDel AdvanceFrameCallback;

	private static OnEventDel OnEventCallback;

	private static SendDel SendCallback;

	private static SystemLogger defaultLogger;

	private static SystemLogger syncTestLogger;

	static GGPO()
	{
	}

	public static void SetCallbacks(SaveGameStateDel saveCallback, LoadGameStateDel loadCallback, AdvanceFrameDel advanceFrameCallback, OnEventDel onEventCallback)
	{
	}

	public static GGPOResult StartSession(string name, int numPlayers, int inputSize, ushort localPort)
	{
		return default(GGPOResult);
	}

	public static GGPOResult StartSyncTest(string name, int numPlayers, int inputSize, int frames)
	{
		return default(GGPOResult);
	}

	public static GGPOResult CloseSession()
	{
		return default(GGPOResult);
	}

	public static bool HasActiveSession()
	{
		return false;
	}

	public static void AddLocalPlayer(int playerNumber, int frameDelay = 8)
	{
	}

	public static void AddRemotePlayer(int playerNumber, string ipAddress, ushort port)
	{
	}

	public static void Update(int timeout = 0)
	{
	}

	public static void AdvanceFrame()
	{
	}

	public static GGPOResult AddLocalInput(byte[] inputBuffer, bool syncTest = false)
	{
		return default(GGPOResult);
	}

	public static GGPOResult SynchronizeInputs(ref byte[] syncedInputs)
	{
		return default(GGPOResult);
	}

	public static GGPOResult SetDisconnectTimeout(int timeoutInSeconds)
	{
		return default(GGPOResult);
	}

	public static GGPOResult SetDisconnectNotifyStart(int timeoutInSeconds)
	{
		return default(GGPOResult);
	}

	public static int GetCurrentFrame()
	{
		return 0;
	}

	public static int GetLastConfirmedFrame()
	{
		return 0;
	}

	public static bool IsRollback()
	{
		return false;
	}

	public static GGPOResult GetNetworkStats(ref GGPONetworkStats stats)
	{
		return default(GGPOResult);
	}

	public static void SetNativeLoggingEnabled(bool enabled)
	{
	}

	public static void SetSendCallback(bool enabled, SendDel sendCallback)
	{
	}

	public static void SetReceivedData(byte[] bytes, int length)
	{
	}

	public static bool ArePlayersReady()
	{
		return false;
	}

	public static int GetPlayerNumber(bool local = true)
	{
		return 0;
	}

	public static GGPOPlayerState GetRemotePlayerState()
	{
		return default(GGPOPlayerState);
	}

	private static void SetConnectState(int playerHandle, GGPOPlayerState state)
	{
	}

	private static void SetIsDisconnecting(int playerHandle, int now, int timeout)
	{
	}

	private static void UpdateConnectProgress(int playerHandle, int progress)
	{
	}

	private static bool BeginGame(string game)
	{
		return false;
	}

	private static bool SaveGameState(IntPtr buffer, IntPtr length, IntPtr checksum, int frame)
	{
		return false;
	}

	private static bool LoadGameState(IntPtr buffer, int length)
	{
		return false;
	}

	private static bool LogGameState(string filename, IntPtr buffer, int length)
	{
		return false;
	}

	private static bool CompareGameStates(IntPtr bufferA, int lengthA, IntPtr bufferB, int lengthB)
	{
		return false;
	}

	private static void FreeBuffer(IntPtr buffer)
	{
	}

	private static bool AdvanceFrame(int flags)
	{
		return false;
	}

	private static bool OnEvent(IntPtr info)
	{
		return false;
	}

	private static void Send(IntPtr buffer, int length)
	{
	}

	private static void OnLogFromGGPONative(byte type, byte verbosity, string str)
	{
	}
}
