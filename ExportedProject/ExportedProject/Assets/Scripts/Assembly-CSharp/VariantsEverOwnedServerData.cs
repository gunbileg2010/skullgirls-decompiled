using System.Collections.Generic;

public class VariantsEverOwnedServerData
{
	public enum OwnedStatus
	{
		NotOwned = 0,
		Owned = 1,
		OwnedShiny = 2
	}

	public string baseCharacterGuid;

	public Dictionary<int, long> variantsEverOwned;

	public Dictionary<int, long> variantsEverOwnedShiny;

	public VariantsEverOwnedServerData(Dictionary<string, object> dataDict)
	{
	}

	public VariantsEverOwnedServerData()
	{
	}

	public void FromDictionary(Dictionary<string, object> dataDict)
	{
	}

	public OwnedStatus IsVariantEverOwned(int variantIndex)
	{
		return default(OwnedStatus);
	}
}
