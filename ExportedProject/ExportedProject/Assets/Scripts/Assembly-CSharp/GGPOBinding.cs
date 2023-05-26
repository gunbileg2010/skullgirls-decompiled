using System;
using System.Runtime.InteropServices;

public static class GGPOBinding
{
	public struct SessionCallbacks
	{
		public IntPtr begin_game;

		public IntPtr save_game_state;

		public IntPtr load_game_state;

		public IntPtr log_game_state;

		public IntPtr compare_game_states;

		public IntPtr free_buffer;

		public IntPtr advance_frame;

		public IntPtr on_event;
	}

	public delegate bool BeginGameDel(string str);

	public delegate bool SaveGameStateDel(IntPtr ip, IntPtr ip2, IntPtr ip3, int i);

	public delegate bool LoadGameStateDel(IntPtr ip, int i);

	public delegate bool LogGameStateDel(string str, IntPtr ip, int i);

	public delegate bool CompareGameStatesDel(IntPtr ip, int i, IntPtr ip2, int i2);

	public delegate void FreeBufferDel(IntPtr ip);

	public delegate bool AdvanceFrameDel(int i);

	public delegate bool OnEventDel(IntPtr ip);

	public delegate void LogFuncDel(byte type, byte verbosity, string str);

	public delegate void SendDel(IntPtr ip, int i);

	private const string kPluginName = "ggpo";

	[PreserveSig]
	public static extern GGPOResult ggpo_start_session(IntPtr sessionPtr, ref SessionCallbacks callbacks, string name, int numPlayers, int inputSize, IntPtr transportPtr);

	[PreserveSig]
	public static extern GGPOResult ggpo_start_synctest(IntPtr sessionPtr, ref SessionCallbacks callbacks, string name, int numPlayers, int inputSize, int frames);

	[PreserveSig]
	public static extern GGPOResult ggpo_close_session(IntPtr session);

	[PreserveSig]
	public static extern GGPOResult ggpo_add_player(IntPtr session, IntPtr player, ref int playerHandle);

	[PreserveSig]
	public static extern GGPOResult ggpo_add_local_player(IntPtr session, int playerNum, ref int playerHandle);

	[PreserveSig]
	public static extern GGPOResult ggpo_add_remote_player(IntPtr session, int playerNum, ref GGPO.GGPORemote remote, ref int playerHandle);

	[PreserveSig]
	public static extern GGPOResult ggpo_disconnect_player(IntPtr session, int playerHandle);

	[PreserveSig]
	public static extern GGPOResult ggpo_idle(IntPtr session, int timeout);

	[PreserveSig]
	public static extern GGPOResult ggpo_advance_frame(IntPtr session);

	[PreserveSig]
	public static extern GGPOResult ggpo_add_local_input(IntPtr session, int playerHandle, IntPtr values, int size);

	[PreserveSig]
	public static extern GGPOResult ggpo_synchronize_input(IntPtr session, IntPtr values, int size, ref int disconnectFlags);

	[PreserveSig]
	public static extern GGPOResult ggpo_set_frame_delay(IntPtr session, int playerHandle, int ggpo_set_frame_delay);

	[PreserveSig]
	public static extern GGPOResult ggpo_set_disconnect_timeout(IntPtr session, int timeout);

	[PreserveSig]
	public static extern GGPOResult ggpo_set_disconnect_notify_start(IntPtr session, int timeout);

	[PreserveSig]
	public static extern int ggpo_get_current_frame(IntPtr session);

	[PreserveSig]
	public static extern int ggpo_get_last_confirmed_frame(IntPtr session);

	[PreserveSig]
	public static extern bool ggpo_get_is_rollback(IntPtr session);

	[PreserveSig]
	public static extern GGPOResult ggpo_get_network_stats(IntPtr session, int playerHandle, IntPtr stats);

	[PreserveSig]
	public static extern void ggpo_set_log_callback(IntPtr logCallback);

	[PreserveSig]
	public static extern IntPtr ggpo_create_socket_transport(ushort localPort);

	[PreserveSig]
	public static extern IntPtr ggpo_create_proxy_transport(IntPtr callback);

	[PreserveSig]
	public static extern void ggpo_proxy_transport_receive(IntPtr proxyTransport, IntPtr data, int length);

	[PreserveSig]
	public static extern void ggpo_free_transport(IntPtr transport);

	[PreserveSig]
	public static extern void ggpo_change_transport(IntPtr session, IntPtr transport);
}
