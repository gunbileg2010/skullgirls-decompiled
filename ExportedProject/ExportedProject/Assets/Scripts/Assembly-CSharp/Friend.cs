using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class Friend
{
	public FriendType friendType;

	public string userId;

	public string userBusinessId;

	public string name;

	public int score;

	public string imageUrl;

	public bool installed;

	public bool isLocalPlayer;

	public bool isFake;

	private Texture2D picture;

	public DateTime? birthday;

	public FriendGender gender;

	public Texture2D Picture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public event Action<Texture2D> PictureUpdated
	{
		add
		{
		}
		remove
		{
		}
	}

	private event Action<Texture2D> PictureUpdatedList
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

	public Friend()
	{
	}

	public Friend(FriendType type)
	{
	}

	public void Dispose()
	{
	}

	public void GetPicture()
	{
	}

	public bool HasPicture()
	{
		return false;
	}

	public void ClearPicture()
	{
	}

	private void InvokePictureUpdatedEvent()
	{
	}

	private IEnumerator RequestPicture()
	{
		return null;
	}
}
