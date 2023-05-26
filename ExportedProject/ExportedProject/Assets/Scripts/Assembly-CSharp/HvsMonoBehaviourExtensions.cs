using System;
using System.Collections;
using UnityEngine;

public static class HvsMonoBehaviourExtensions
{
	public static Coroutine ExecuteOnNextFrame(this MonoBehaviour behavior, Action delayed)
	{
		return null;
	}

	public static Coroutine ExecuteOnFixedUpdate(this MonoBehaviour behavior, Action delayed)
	{
		return null;
	}

	public static Coroutine ExecuteAfterSeconds(this MonoBehaviour behavior, float seconds, Action delayed)
	{
		return null;
	}

	public static Coroutine ExecuteAfterCondition(this MonoBehaviour behavior, Func<bool> condition, Action delayed)
	{
		return null;
	}

	private static IEnumerator NextFrameExecution(Action delayed)
	{
		return null;
	}

	private static IEnumerator FixedUpdateExecution(Action delayed)
	{
		return null;
	}

	private static IEnumerator AfterSecondsExecution(float seconds, Action delayed)
	{
		return null;
	}

	private static IEnumerator AfterConditionExecution(Func<bool> condition, Action delayed)
	{
		return null;
	}
}
