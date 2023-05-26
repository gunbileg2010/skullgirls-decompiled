using BoltInternal;
using UdpKit;

public class BoltDebugStart : GlobalEventListenerBase
{
	private UdpEndPoint _serverEndPoint;

	private UdpEndPoint _clientEndPoint;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public override void BoltStartFailed()
	{
	}

	public override void BoltStartDone()
	{
	}

	public override void SceneLoadLocalDone(string map)
	{
	}
}
