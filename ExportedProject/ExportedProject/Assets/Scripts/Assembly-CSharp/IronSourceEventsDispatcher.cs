using System;
using System.Collections.Generic;
using UnityEngine;

public class IronSourceEventsDispatcher : MonoBehaviour
{
	private static IronSourceEventsDispatcher instance;

	private static readonly Queue<Action> ironSourceExecuteOnMainThreadQueue;

	public static void executeAction(Action action)
	{
	}

	private void Update()
	{
	}

	public void removeFromParent()
	{
	}

	public static void initialize()
	{
	}

	public static bool isCreated()
	{
		return false;
	}

	public void Awake()
	{
	}

	public void OnDisable()
	{
	}
}
