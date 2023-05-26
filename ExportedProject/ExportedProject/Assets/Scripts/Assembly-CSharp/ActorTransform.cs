using System;
using UnityEngine;

[Serializable]
public class ActorTransform
{
	[SerializeField]
	[ReadOnly]
	private Transform _cachedTransform;

	[SerializeField]
	private Fixed3 _fixedPosition;

	[SerializeField]
	[ReadOnly]
	private Fixed3 _fixedScale;

	[ReadOnly]
	[SerializeField]
	private Fixed _fixedArtRotAngle;

	private bool isLocalPlayerP1;

	public Transform CachedTransform
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Fixed3 FixedPosition
	{
		get
		{
			return default(Fixed3);
		}
		set
		{
		}
	}

	public Fixed3 FixedScale
	{
		get
		{
			return default(Fixed3);
		}
		set
		{
		}
	}

	public Fixed FixedArtRotAngle
	{
		get
		{
			return default(Fixed);
		}
		set
		{
		}
	}

	public void Reset()
	{
	}

	public void SetLocalPlayerIsP1(bool isP1)
	{
	}

	public bool GetIsLocalPlayerP1()
	{
		return false;
	}
}
