using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TimestepManager : MonoBehaviour
{
	private class TimestepCallback
	{
		public int priority;

		public Action updateCallback;
	}

	public const int kFps = 60;

	public const float kFrameDt = 1f / 60f;

	public const int kFrameSkipInterval = 6;

	public const int kEffectiveFps = 70;

	public const float kEffectiveFrameDt = 1f / 70f;

	private float accumulatedTimeDelta;

	private List<TimestepCallback> timestepCallbacks;

	private int frameSkipCounter;

	private bool willRenderThisFrame;

	private bool doingFirstTimestepOfUpdate;

	private int frameSkipFramesToIgnore;

	public event Action TimestepsStarted
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action TimestepsFinished
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Update()
	{
	}

	public void AddUpdateCallback(int priority, Action callback)
	{
	}

	public void RemoveUpdateCallback(Action callback)
	{
	}

	public bool WillRenderAfterThisStep()
	{
		return false;
	}

	public bool IsFirstTimestepOfUpdate()
	{
		return false;
	}

	public void SimulateFrame()
	{
	}

	public void SetFrameSkipIgnoreFrames(int framesToIngore)
	{
	}

	private void InvokeTimestepCallbacks()
	{
	}
}
