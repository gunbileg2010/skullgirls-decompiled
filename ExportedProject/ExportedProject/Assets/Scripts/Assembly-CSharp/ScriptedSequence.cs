using System.Collections.Generic;
using UnityEngine;

public class ScriptedSequence : MonoBehaviour
{
	public List<SequentialAction> actions;

	private static int runningCount;

	private bool isRunning;

	private int actionIndex;

	private void Awake()
	{
	}

	public static bool IsAnyRunning()
	{
		return false;
	}

	public int GetCurrentActionIndex()
	{
		return 0;
	}

	public bool IsRunning()
	{
		return false;
	}

	public void Stop()
	{
	}

	private void StartSequence()
	{
	}

	private void OnActionComplete()
	{
	}

	private void DoNextAction()
	{
	}
}
