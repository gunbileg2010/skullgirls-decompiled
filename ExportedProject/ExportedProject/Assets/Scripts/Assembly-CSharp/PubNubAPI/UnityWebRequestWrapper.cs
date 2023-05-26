using UnityEngine.Networking;

namespace PubNubAPI
{
	internal class UnityWebRequestWrapper
	{
		internal UnityWebRequest CurrentUnityWebRequest;

		internal string URL;

		internal int Timeout;

		internal int Pause;

		internal PNCurrentRequestType CurrentRequestType;

		internal bool IsComplete;

		internal RequestState CurrentRequestState;

		internal bool RunTimer;

		internal float Timer;

		internal bool RunPauseTimer;

		internal float PauseTimer;

		internal UnityWebRequestWrapper(PNCurrentRequestType crt, RequestState requestState)
		{
		}
	}
}
