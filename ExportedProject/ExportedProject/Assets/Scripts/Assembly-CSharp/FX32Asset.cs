using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class FX32Asset : ScriptableObject
{
	[SerializeField]
	private Sprite[] frames;

	[SerializeField]
	private DynamicResource spriteAtlas;

	[SerializeField]
	private BaseCharacterData baseCharacter;

	[NonSerialized]
	private SpriteAtlas loadedSpriteAtlas;

	[NonSerialized]
	private Sprite[] loadedFrames;

	public Sprite[] GetFrames()
	{
		return null;
	}

	public void Load(List<BaseCharacterData> baseCharactersInFight)
	{
	}

	public void Unload()
	{
	}
}
