using System;
using Bolt;

[Documentation]
public class BoltEntitySettingsModifier : IDisposable
{
	private BoltEntity _entity;

	public PrefabId prefabId
	{
		get
		{
			return default(PrefabId);
		}
		set
		{
		}
	}

	public UniqueId sceneId
	{
		get
		{
			return default(UniqueId);
		}
		set
		{
		}
	}

	public UniqueId serializerId
	{
		get
		{
			return default(UniqueId);
		}
		set
		{
		}
	}

	public int updateRate
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int autoFreezeProxyFrames
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool clientPredicted
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool allowInstantiateOnClient
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool persistThroughSceneLoads
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool sceneObjectDestroyOnDetach
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool sceneObjectAutoAttach
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool alwaysProxy
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal BoltEntitySettingsModifier(BoltEntity entity)
	{
	}

	private void System_002EIDisposable_002EDispose()
	{
	}
}
