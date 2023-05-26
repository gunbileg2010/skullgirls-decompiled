using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PubNubAPI
{
	internal class PNUnityWebRequest : MonoBehaviour
	{
		internal PNLoggingMethod PNLog;

		private readonly object syncRoot;

		private static string[][] _unused;

		private static int[][] _unused2;

		private static long[][] _unused3;

		private static short[][] _unused4;

		private static ushort[][] _unused5;

		private static ulong[][] _unused6;

		private static uint[][] _unused7;

		private static decimal[][] _unused8;

		private static double[][] _unused9;

		private static bool[][] _unused91;

		private static object[][] _unused92;

		private static long[][] _unused10;

		private static int[][] _unused11;

		private static float[][] _unused12;

		private static decimal[][] _unused13;

		private static uint[][] _unused14;

		private static ulong[][] _unused15;

		public const float timerConst = 0f;

		public float timer;

		private readonly SafeDictionary<string, UnityWebRequestWrapper> currentWebRequests;

		private List<string> keys;

		public event EventHandler<EventArgs> WebRequestComplete
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

		internal CurrentRequestTypeEventArgs CreateCurrentRequestTypeEventArgs(UnityWebRequestWrapper unityWebRequestWrapper, bool isTimeout)
		{
			return null;
		}

		internal void RaiseEvents(bool isTimeout, UnityWebRequestWrapper unityWebRequestWrapper, string key)
		{
		}

		internal void CheckElapsedTime(UnityWebRequestWrapper unityWebRequestWrapper, string key)
		{
		}

		internal void CheckPauseTime(UnityWebRequestWrapper unityWebRequestWrapper, string key)
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		internal void StopTimeoutsAndComplete(UnityWebRequestWrapper unityWebRequestWrapper, string key, bool pauseOnly)
		{
		}

		private string GenerateAndValidateWebRequestId()
		{
			return null;
		}

		public void CleanUp()
		{
		}

		public void AbortRequest(string webRequestId, bool fireEvent)
		{
		}

		public string Run(RequestState pubnubRequestState)
		{
			return null;
		}

		internal void GetOrPostOrDelete(ref UnityWebRequestWrapper unityWebRequestWrapper)
		{
		}

		internal void StartWebRequests(UnityWebRequestWrapper unityWebRequestWrapper, string key)
		{
		}

		public void ProcessResponse(UnityWebRequestWrapper unityWebRequestWrapper, string key)
		{
		}

		public void ProcessTimeout(UnityWebRequestWrapper unityWebRequestWrapper, string key, bool isComplete)
		{
		}

		public void FireEvent(string message, bool isError, bool isTimeout, RequestState pubnubRequestState, PNCurrentRequestType crt, string key)
		{
		}
	}
}
