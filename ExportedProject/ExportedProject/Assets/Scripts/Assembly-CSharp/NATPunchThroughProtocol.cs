using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;

public class NATPunchThroughProtocol
{
	private enum State
	{
		ReadyToExecute = 0,
		InProgress = 1,
		Success = 2,
		Error = 3,
		PingMeasured = 4
	}

	private const int kSendCount = 40;

	private const float kSecondsBetweenSends = 0.1f;

	private const int kPingMeasureCount = 10;

	private const byte kInitialPing = 1;

	private const byte kInitialPong = 2;

	private const byte kConfirmPing = 3;

	private const byte kConfirmPong = 4;

	private const byte kPingMeasurePing = 5;

	private const byte kPingMeasurePong = 6;

	private State state;

	private UdpClient udpToUse;

	private IPEndPoint endpointToConfirm;

	private string ipToUse;

	private int portToUse;

	private Thread receiveThread;

	private List<int> pingMsMeasurements;

	private int pingMeasurementsPonged;

	private Stopwatch pingStopwatch;

	public void Execute(int listenPort, byte keyByte, string targetIp, int targetPort, Action<bool> callback)
	{
	}

	public string GetUsableIP()
	{
		return null;
	}

	public int GetUsablePort()
	{
		return 0;
	}

	public int GetPingMs()
	{
		return 0;
	}

	private void ReceiveThreadFunction(byte keyByte)
	{
	}

	private IEnumerator SendCoroutine(byte keyByte, string targetIp, int targetPort, Action<bool> callback)
	{
		return null;
	}

	private void WriteLongToByteArray(byte[] bytes, int offset)
	{
	}
}
