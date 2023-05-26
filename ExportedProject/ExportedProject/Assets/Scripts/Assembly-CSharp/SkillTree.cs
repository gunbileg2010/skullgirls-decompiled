using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SkillTree : Graph, IServerUploadable
{
	[SerializeField]
	[Lockable]
	private string guid;

	[SerializeField]
	private SkillTreeNode rootNode;

	[SerializeField]
	private List<SkillTreeNode> purchaseOrder;

	[NonSerialized]
	private bool isInitialized;

	[NonSerialized]
	private List<SkillTreeNode> _nodes;

	[NonSerialized]
	private Dictionary<SkillTreeNodeType, List<SkillTreeNode>> _nodesByType;

	[NonSerialized]
	private Dictionary<string, SkillTreeNode> _nodeGuidLookup;

	private List<SkillTreeNode> nodes => null;

	private Dictionary<SkillTreeNodeType, List<SkillTreeNode>> nodesByType => null;

	private Dictionary<string, SkillTreeNode> nodeGuidLookup => null;

	private void Awake()
	{
	}

	public void RefreshLockedStates(Character character)
	{
	}

	public SkillTreeNode GetNodeByGuid(string guid)
	{
		return null;
	}

	public List<SkillTreeNode> GetSkillTreeNodes()
	{
		return null;
	}

	public List<SkillTreeNode> GetNodesOfType(SkillTreeNodeType type)
	{
		return null;
	}

	public bool IsSuperAbilityUnlocked(Dictionary<string, SkillTreeNodeStateData> stateData)
	{
		return false;
	}

	public int[] GetSuperAbilityLevels(Dictionary<string, SkillTreeNodeStateData> stateData)
	{
		return null;
	}

	public bool IsSignatureAbilityUnlocked(Dictionary<string, SkillTreeNodeStateData> stateData)
	{
		return false;
	}

	public int[] GetSignatureAbilityLevels(Dictionary<string, SkillTreeNodeStateData> stateData)
	{
		return null;
	}

	public bool IsBlockbusterUnlocked(int tier, Dictionary<string, SkillTreeNodeStateData> stateData)
	{
		return false;
	}

	public int GetBlockbusterLevel(int tier, Dictionary<string, SkillTreeNodeStateData> stateData)
	{
		return 0;
	}

	public bool IsTripUnlocked(Dictionary<string, SkillTreeNodeStateData> stateData)
	{
		return false;
	}

	public bool IsChargeUnlocked(Dictionary<string, SkillTreeNodeStateData> stateData)
	{
		return false;
	}

	public bool IsChargeUpgradeUnlocked(Dictionary<string, SkillTreeNodeStateData> stateData)
	{
		return false;
	}

	public bool IsAdvancedComboUnlocked(Dictionary<string, SkillTreeNodeStateData> stateData)
	{
		return false;
	}

	public bool IsAdvancedJuggleUnlocked(Dictionary<string, SkillTreeNodeStateData> stateData)
	{
		return false;
	}

	public bool IsCharacterAbilityUnlocked(Dictionary<string, SkillTreeNodeStateData> stateData)
	{
		return false;
	}

	public float CalculateBuff(SkillTreeNodeType nodeType, Dictionary<string, SkillTreeNodeStateData> stateData)
	{
		return 0f;
	}

	public float GetFSMultiplierAddition(VariantCharacterData variantData, Dictionary<string, SkillTreeNodeStateData> stateData)
	{
		return 0f;
	}

	public int GetAdvancedStatNodesPurchased(Dictionary<string, SkillTreeNodeStateData> stateData)
	{
		return 0;
	}

	public void SwapSuperAbility(Dictionary<string, SkillTreeNodeStateData> stateData)
	{
	}

	public Currency GetAutoSpendCost(int points, Character character)
	{
		return null;
	}

	public int PurchaseNodesWithPoints(int points, Character character)
	{
		return 0;
	}

	public bool CanPurchaseUpgradeWithPoints(Character character, int availablePoints)
	{
		return false;
	}

	public string GetGuid()
	{
		return null;
	}

	public List<SkillTreeNode> GetPurchaseOrder()
	{
		return null;
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	private void Init()
	{
	}

	private int GetPurchasedNodeCount(SkillTreeNodeType nodeType, Dictionary<string, SkillTreeNodeStateData> stateData)
	{
		return 0;
	}

	private bool IsAbilityUnlocked(Dictionary<string, SkillTreeNodeStateData> stateData, SkillTreeNodeType abilityType, int tier = 1)
	{
		return false;
	}
}
