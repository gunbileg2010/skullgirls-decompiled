using System.Collections.Generic;

public class EnemyCharacterServerData
{
	public VariantCharacterData variantCharacterData;

	public RarityTier tier;

	public int level;

	public int lifebar;

	public int attack;

	public int fighterScore;

	public string[] skillNodeGuids;

	public List<Gear> gears;

	public int[] superAbilityLevels;

	public int superAbilityActiveFeatureSet;

	public int prestigeAbilityLevel;

	public bool isShiny;

	private bool isRandom;

	public EnemyCharacterServerData()
	{
	}

	public EnemyCharacterServerData(Dictionary<string, object> dataDict)
	{
	}

	public void ParseData(Dictionary<string, object> dataDict)
	{
	}

	public bool IsRandom()
	{
		return false;
	}
}
