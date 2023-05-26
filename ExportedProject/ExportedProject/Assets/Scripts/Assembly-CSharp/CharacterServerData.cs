using System;
using System.Collections.Generic;

public class CharacterServerData
{
	public class CharacterServerEnergy
	{
		public int energy;

		public DateTime nextEnergyDateTime;
	}

	public string backendId;

	public VariantCharacterData variantCharacterData;

	public RarityTier tier;

	public double levelAndProgress;

	public long experience;

	public int lifebar;

	public int attack;

	public string[] skillNodeGuids;

	public int[] superAbilityLevels;

	public int superAbilityActiveFeatureSet;

	public int prestigeAbilityLevel;

	public bool isLocked;

	public bool isNew;

	public bool isUsedInDeployment;

	public bool isShiny;

	public CharacterServerEnergy standardEnergy;

	public CharacterServerEnergy multiplayerEnergy;

	public List<string> offensiveGearGuids;

	public CharacterServerData(Dictionary<string, object> dataDict)
	{
	}

	public void ParseData(Dictionary<string, object> dataDict)
	{
	}
}
