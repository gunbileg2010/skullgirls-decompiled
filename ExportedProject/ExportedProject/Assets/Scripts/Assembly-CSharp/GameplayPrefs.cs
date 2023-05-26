using UnityEngine;

public static class GameplayPrefs
{
	public static float musicVolume;

	public static float sfxVolume;

	private static bool lightingEnabled;

	private static bool superShadowsEnabled;

	private static bool useJapaneseVO;

	private static bool chatEnabled;

	private static bool showFightAssist;

	private static bool reducedFlashing;

	private static Vector2 screenResolution;

	private static bool limitFramerate;

	private static int syncPvpPingThresholdIndex;

	private static int syncPvpFrameDelay;

	private static bool syncPvpAllowRelay;

	private static bool syncPvpShowInfo;

	public static bool LightingEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool SuperShadowsEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool UseJapaneseVO
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool ChatEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool ShowFightAssist
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool ReducedFlashing
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static Vector2 ScreenResolution
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public static bool LimitFramerate
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static int SyncPvpPingThresholdIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int SyncPvpPingThreshold => 0;

	public static int SyncPvpFrameDelay
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static bool SyncPvpAllowRelay
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool SyncPvpShowNetInfo
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static void Load()
	{
	}
}
