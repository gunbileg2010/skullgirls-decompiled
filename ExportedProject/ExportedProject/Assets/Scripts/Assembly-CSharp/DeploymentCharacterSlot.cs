using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class DeploymentCharacterSlot
{
	[SerializeField]
	private CharacterConstraint characterConstraint;

	[SerializeField]
	private ElementConstraint elementConstraint;

	[SerializeField]
	private TierConstraint tierConstraint;

	private KeyValuePair<BaseCharacterData, bool> deserializedCharacterConstraint;

	private KeyValuePair<Element?, bool> deserializedElementConstraint;

	private KeyValuePair<RarityTier?, bool> deserializedTierConstraint;

	public DeploymentCharacterSlot()
	{
	}

	public DeploymentCharacterSlot(Dictionary<string, object> dataDict)
	{
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	public KeyValuePair<BaseCharacterData, bool> GetDeserializedCharacterConstraint()
	{
		return default(KeyValuePair<BaseCharacterData, bool>);
	}

	public KeyValuePair<Element?, bool> GetDeserializedElementConstraint()
	{
		return default(KeyValuePair<Element?, bool>);
	}

	public KeyValuePair<RarityTier?, bool> GetDeserializedTierConstraint()
	{
		return default(KeyValuePair<RarityTier?, bool>);
	}
}
