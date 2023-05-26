using System;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineManager : MonoBehaviour, IRunOnMainThread
{
	private Queue<Action> mainThreadCallbackQueue;

	private void Update()
	{
	}

	public void RunOnMainThread(Action action)
	{
	}
}
