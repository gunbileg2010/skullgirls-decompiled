using System.Collections.Generic;

public class RiftBattleMapNodeServerData
{
	public List<string> characterIds;

	public List<EnemyCharacterServerData> characters;

	public List<string> modifierIds;

	public List<CollectibleNodeModifierServerData> modifiers;

	public RiftBattleMapNodeServerData()
	{
	}

	public RiftBattleMapNodeServerData(Dictionary<string, object> data)
	{
	}

	public Dictionary<string, object> GetUploadData()
	{
		return null;
	}

	public RiftBattleMapNodeServerData GetCopy()
	{
		return null;
	}

	private void ParseData(Dictionary<string, object> data)
	{
	}
}
