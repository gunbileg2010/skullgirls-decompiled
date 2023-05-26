using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SkillTreeNode : GraphNode
{
	[Lockable]
	[SerializeField]
	private string guid;

	[SerializeField]
	private string humanReadableGuid;

	public SkillTreeNodeType nodeType;

	public float value;

	[SerializeField]
	private int featureSetIndex;

	[SerializeField]
	private float fsMultiplierAddition;

	public int skillPointCost;

	public Currency cost;

	public Currency shortcutCost;

	[SerializeField]
	private string[] scItemCodes;

	[SerializeField]
	private string[] hcItemCodes;

	[SerializeField]
	private bool isPriority;

	[SerializeField]
	private int requiredLevel;

	[SerializeField]
	private List<SkillTreeNode> mutuallyExclusiveNodes;

	[SerializeField]
	private List<SkillTreeNode> multiParentNodes;

	[SerializeField]
	private bool isFloating;

	[SerializeField]
	private bool isHidden;

	[NonSerialized]
	private List<SkillTreeNode> skillTreeConnections;

	private bool locked;

	private void Awake()
	{
	}

	public override GraphConnectionType GetConnectionType(GraphNode connection, object context)
	{
		return default(GraphConnectionType);
	}

	public List<SkillTreeNode> GetSkillTreeConnections()
	{
		return null;
	}

	public bool IsLocked()
	{
		return false;
	}

	public void SetLocked(bool isLocked)
	{
	}

	public string GetGuid()
	{
		return null;
	}

	public string GetHumanReadableGuid()
	{
		return null;
	}

	public int GetFeatureSetIndex()
	{
		return 0;
	}

	public float GetFSMultiplierAddition()
	{
		return 0f;
	}

	public bool IsTempNode()
	{
		return false;
	}

	public bool IsPurchased(Dictionary<string, SkillTreeNodeStateData> stateData)
	{
		return false;
	}

	public bool IsPurchased(SkillTreeNodeStateData stateData)
	{
		return false;
	}

	public bool AreDependenciesMet(Character character)
	{
		return false;
	}

	public bool IsInLockedZone(Character character, out SkillTreeNode gateNode)
	{
		gateNode = null;
		return false;
	}

	public SkillTreeNodeType GetNodeType()
	{
		return default(SkillTreeNodeType);
	}

	public bool IsMutuallyExclusive()
	{
		return false;
	}

	public bool IsMultiDependent()
	{
		return false;
	}

	public bool DoesAbilityExist(Character character)
	{
		return false;
	}

	public bool IsFloating()
	{
		return false;
	}

	public bool IsHidden()
	{
		return false;
	}

	public bool IsFree()
	{
		return false;
	}

	public Currency GetScaledShortcutCost(RarityTier tier, bool isShiny = false)
	{
		return null;
	}

	public Price GetScaledPrice(RarityTier tier, BaseCharacterData baseCharacterData, bool isShiny = false)
	{
		return null;
	}

	public bool IsPriority()
	{
		return false;
	}

	public int GetRequiredLevel()
	{
		return 0;
	}

	public bool IsShortcutable()
	{
		return false;
	}

	public string GetSignatureAbilityDetails(Character character, SignatureAbility signatureAbility)
	{
		return null;
	}

	public string GetFeatureSetDetails(Character character, SignatureAbility signatureAbility)
	{
		return null;
	}

	public string GetDescription(Character character)
	{
		return null;
	}

	public string GetNodeName(Character character)
	{
		return null;
	}

	public Dictionary<string, object> GetServerUploadData(string treeGuid, List<SkillTreeNode> parentNodes)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	private bool AllParentsPurchased(Character character)
	{
		return false;
	}

	private bool AreMutualNodesNotPurchased(Character character)
	{
		return false;
	}

	private bool IsCharacterAboveRequiredLevel(Character character)
	{
		return false;
	}

	private void GenerateGuid()
	{
	}
}
