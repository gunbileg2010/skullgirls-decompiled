using System.Collections.Generic;
using UnityEngine;

public class RiftBattleModifierConfiguration : GuidScriptableObject, IServerUploadable
{
	[SerializeField]
	private BattleNodeModifiers[] nodeModifiers;

	public BattleNodeModifiers GetNodeModifiersForIndex(int index)
	{
		return null;
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
