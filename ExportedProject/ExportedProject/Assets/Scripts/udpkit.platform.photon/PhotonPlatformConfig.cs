using System;
using System.Reflection;
using udpkit.platform.photon;

public class PhotonPlatformConfig
{
	public PhotonRegion Region;

	public bool UsePunchThrough;

	private string _appID;

	private string _regionMaster;

	private float _roomUpdateRate;

	private float _roomCreateTimeout;

	private float _roomJoinTimeout;

	private object _boltRuntimeSettingsInstance;

	private Type _boltRuntimeSettings;

	private Type _boltNetwork;

	private const BindingFlags STATIC = BindingFlags.Static | BindingFlags.Public;

	private const BindingFlags INSTANCE = BindingFlags.Instance | BindingFlags.Public;

	public string AppId
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float RoomUpdateRate
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float RoomCreateTimeout
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float RoomJoinTimeout
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private object[] NO_ARGS => null;

	internal PhotonPlatformConfig InitDefaults()
	{
		return null;
	}

	internal void UpdateBestRegion(PhotonRegion region)
	{
	}

	internal bool IsAppId(string val)
	{
		return false;
	}
}
