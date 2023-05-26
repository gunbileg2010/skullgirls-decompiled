using System.Runtime.CompilerServices;
using UdpKit;

public static class BoltLauncher
{
	private static UdpPlatform TargetPlatform
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static void StartSinglePlayer(BoltConfig config = null)
	{
	}

	public static void StartServer(int port = -1)
	{
	}

	public static void StartServer(BoltConfig config, string scene = null)
	{
	}

	public static void StartServer(UdpEndPoint endpoint, string scene = null)
	{
	}

	public static void StartServer(UdpEndPoint endpoint, BoltConfig config, string scene = null)
	{
	}

	public static void StartClient(int port = -1)
	{
	}

	public static void StartClient(BoltConfig config)
	{
	}

	public static void StartClient(UdpEndPoint endpoint, BoltConfig config = null)
	{
	}

	private static void Initialize(BoltNetworkModes modes, UdpEndPoint endpoint, BoltConfig config, string scene = null)
	{
	}

	public static void Shutdown()
	{
	}

	public static void SetUdpPlatform(UdpPlatform platform)
	{
	}
}
