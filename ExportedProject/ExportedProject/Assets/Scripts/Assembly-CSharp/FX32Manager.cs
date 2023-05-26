using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class FX32Manager : MonoBehaviour
{
	public FX32Asset[] fxAssets;

	private Dictionary<uint, FX32Asset> fx32Lookup;

	private void Awake()
	{
	}

	public Sprite[] GetFramesForFX32Hash(uint hash)
	{
		return null;
	}

	public void LoadDynamicFX32s(List<BaseCharacterData> baseCharactersInFight)
	{
	}

	public void UnloadDynamicFX32s()
	{
	}

	private void OnSpriteAtlasRequested(string name, Action<SpriteAtlas> callback)
	{
	}
}
