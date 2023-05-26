using System.Collections.Generic;
using UnityEngine;

public class VariantCharacterSet : GuidScriptableObject, IServerUploadable
{
	[SerializeField]
	private List<VariantCharacterData> characters;

	public VariantCharacterData GetRandomCharacter()
	{
		return null;
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
