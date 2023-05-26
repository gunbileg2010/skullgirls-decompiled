using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;

public class StunProtocol
{
	private enum State
	{
		Initialized = 0,
		InProgress = 1,
		Success = 2,
		Error = 3
	}

	private string host;

	private ushort port;

	private State state;

	private UdpClient udp;

	private IPEndPoint localUdpEndpoint;

	private IPAddress stunIp;

	private int stunPort;

	public StunProtocol(string host, ushort port)
	{
	}

	public void Execute(Action<bool> callback)
	{
	}

	public void Execute(int port, Action<bool> callback)
	{
	}

	public void Execute(UdpClient udpClient, Action<bool> callback)
	{
	}

	public void Execute(int localPort, Action<bool> callback, UdpClient udpClient)
	{
	}

	public string GetLocalIP()
	{
		return null;
	}

	public int GetLocalPort()
	{
		return 0;
	}

	public IPAddress GetPublicIP()
	{
		return null;
	}

	public string GetPublicIPString()
	{
		return null;
	}

	public int GetPublicPort()
	{
		return 0;
	}

	private IEnumerator DoStunProtocol(Action<bool> callback, int localPort, UdpClient externalUdpClient)
	{
		return null;
	}

	private void ListenForResponse()
	{
	}
}
