using System;
using UnityEngine;

[Serializable]
public class TalkingHeadEmote
{
	public string name;

	public DynamicResource spriteResource;

	public float alphaMultiplier;

	[NonSerialized]
	private DynamicResource alphaMaskTextureResource;

	public DynamicResource GetAlphaMaskTextureResource()
	{
		return null;
	}

	public Sprite TakeSprite(ref Texture2D alphaMaskTexture)
	{
		return null;
	}

	public void ReturnSprite()
	{
	}
}
