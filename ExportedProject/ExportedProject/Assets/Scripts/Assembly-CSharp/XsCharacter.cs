using System.Collections.Generic;

public class XsCharacter
{
	public int fighterScore;

	public RarityTier tier;

	public bool isSuperAbilityUnlocked;

	public bool isPrestigeAbilityUnlocked;

	public bool isShiny;

	private VariantCharacterData variantCharacterData;

	public XsCharacter()
	{
	}

	public XsCharacter(Character character)
	{
	}

	public XsCharacter(EnemyCharacterServerData character)
	{
	}

	public XsCharacter(Dictionary<string, object> dataDict)
	{
	}

	public void Populate(Character character)
	{
	}

	public void Populate(Dictionary<string, object> dataDict)
	{
	}

	public bool IsRandom()
	{
		return false;
	}

	public VariantCharacterData GetVariantCharacterData()
	{
		return null;
	}

	public void SetVariantCharacterData(VariantCharacterData data)
	{
	}

	public Element GetElement()
	{
		return default(Element);
	}

	public bool IsShiny()
	{
		return false;
	}

	public bool ShowShinyVisuals()
	{
		return false;
	}

	public Dictionary<string, object> ToDictionary()
	{
		return null;
	}

	private void FromDictionary(Dictionary<string, object> dataDict)
	{
	}
}
