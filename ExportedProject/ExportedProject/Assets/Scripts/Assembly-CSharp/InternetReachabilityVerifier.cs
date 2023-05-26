using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class InternetReachabilityVerifier : MonoBehaviour
{
	public enum CaptivePortalDetectionMethod
	{
		DefaultByPlatform = 0,
		Google204 = 1,
		GoogleBlank = 2,
		MicrosoftNCSI = 3,
		Apple = 4,
		Ubuntu = 5,
		Custom = 6,
		Apple2 = 7,
		AppleHTTPS = 8,
		Google204HTTPS = 9,
		UbuntuHTTPS = 10,
		MicrosoftConnectTest = 11,
		MicrosoftNCSI_IPV6 = 12,
		MicrosoftConnectTest_IPV6 = 13
	}

	public enum Status
	{
		Offline = 0,
		PendingVerification = 1,
		Error = 2,
		Mismatch = 3,
		NetVerified = 4
	}

	public delegate void StatusChangedDelegate(Status newStatus);

	public delegate bool CustomMethodVerifierDelegate(UnityWebRequest wr, string customMethodExpectedData);

	private const int version = 1200;

	public CaptivePortalDetectionMethod captivePortalDetectionMethod;

	public string customMethodURL;

	public string customMethodExpectedData;

	public bool dontDestroyOnLoad;

	public bool customMethodWithCacheBuster;

	public float defaultCheckPeriod;

	public float errorRetryDelay;

	public float mismatchRetryDelay;

	[HideInInspector]
	public bool alwaysUseCacheBuster;

	public CustomMethodVerifierDelegate customMethodVerifierDelegate;

	private float noInternetStartTime;

	private Status _status;

	private string _lastError;

	private static InternetReachabilityVerifier _instance;

	private static RuntimePlatform[] methodGoogle204Supported;

	private const CaptivePortalDetectionMethod fallbackMethodIfNoDefaultByPlatform = CaptivePortalDetectionMethod.MicrosoftNCSI;

	private bool netActivityRunning;

	private string apple2MethodURL;

	private float _yieldWaitStart;

	public Status status
	{
		get
		{
			return default(Status);
		}
		set
		{
		}
	}

	public string lastError
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static InternetReachabilityVerifier Instance => null;

	public event StatusChangedDelegate statusChangedDelegate
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

	public float getTimeWithoutInternetConnection()
	{
		return 0f;
	}

	public IEnumerator waitForNetVerifiedStatus()
	{
		return null;
	}

	public void setNetActivityTimes(float defaultCheckPeriodSeconds, float errorRetryDelaySeconds, float mismatchRetryDelaySeconds)
	{
	}

	public void forceReverification()
	{
	}

	private string getCaptivePortalDetectionURL(CaptivePortalDetectionMethod cpdm)
	{
		return null;
	}

	private long iwrGet_bytesDownloaded(UnityWebRequest iwr)
	{
		return 0L;
	}

	private string iwrGet_text(UnityWebRequest iwr)
	{
		return null;
	}

	private byte[] iwrGet_bytes(UnityWebRequest iwr)
	{
		return null;
	}

	private Dictionary<string, string> iwrGet_responseHeaders(UnityWebRequest iwr)
	{
		return null;
	}

	private string iwrGet_responseHeader(UnityWebRequest iwr, string key)
	{
		return null;
	}

	private bool iwrGet_isError(UnityWebRequest iwr)
	{
		return false;
	}

	private bool IsNetworkError(UnityWebRequest iwr)
	{
		return false;
	}

	private string iwrGet_errorString(UnityWebRequest iwr)
	{
		return null;
	}

	private bool checkCaptivePortalDetectionResult(CaptivePortalDetectionMethod cpdm, UnityWebRequest iwr)
	{
		return false;
	}

	private bool internal_yieldWait(float seconds)
	{
		return false;
	}

	private IEnumerator netActivity()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void verifyCaptivePortalDetectionMethod()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	public void Stop()
	{
	}
}
