using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CharacterGenerator
{
	[SerializeField]
	private VariantCharacterData characterData;

	[SerializeField]
	private VariantCharacterSet randomCharacterList;

	[SerializeField]
	private Vector2 levelRange;

	[SerializeField]
	private int extraSkillPoints;

	[SerializeField]
	private RarityTier minCharacterTier;

	public GearGenerator[] gearGenerators;

	private static GearGenerator defaultGearGenerator;

	public Character GenerateCharacter(List<Character> usedCharacters, bool useCollection = false, SkillTree overrideSkillTree = null, Dictionary<string, List<Gear>> gearCollection = null, List<Character> characterCollection = null)
	{
		return null;
	}

	public VariantCharacterData GetVariantData()
	{
		return null;
	}

	public bool IsRandomized()
	{
		return false;
	}

	public Dictionary<string, object> GetServerUploadData(UnityEngine.Object context)
	{
		return null;
	}

	private VariantCharacterData ChooseVariantCharacterData(List<Character> charactersUsed, ref bool isRandom)
	{
		return null;
	}

	private Character BuildCharacterFromData(VariantCharacterData variant, int level)
	{
		return null;
	}
}
