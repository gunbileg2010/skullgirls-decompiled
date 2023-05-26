using System;
using UnityEngine;
using UnityEngine.UI;

public class SkillTreeNodeInfoPopup : MonoBehaviour
{
	public Action<SkillTreeNode> NodePurchased;

	[SerializeField]
	protected LocalizedUGUIText headerText;

	[SerializeField]
	protected LocalizedUGUIText mainText;

	[SerializeField]
	private LocalizedUGUIText abilityText;

	[SerializeField]
	private Image icon;

	[SerializeField]
	protected GameObject nodeDetailsGO;

	[SerializeField]
	protected GameObject statImprovementGO;

	[SerializeField]
	protected GameObject abilityGO;

	[SerializeField]
	private LocalizedUGUIText progressionCurrentText;

	[SerializeField]
	private LocalizedUGUIText progressionImprovedText;

	[SerializeField]
	protected AdvancedButton hcShortcutButton;

	[SerializeField]
	protected AdvancedButton purchaseButton;

	[SerializeField]
	protected GameObject closeButtonGO;

	[SerializeField]
	private LocalizedUGUIText purchasedText;

	[SerializeField]
	protected GameObject levelRequirementGO;

	[SerializeField]
	protected LocalizedUGUIText levelRequirementText;

	[SerializeField]
	protected MasterPopupData purchaseConfirmPopupData;

	[SerializeField]
	private GameObject purchaseButtonGroup;

	[SerializeField]
	private GameObject lockedGO;

	[SerializeField]
	private GameObject gateLocked;

	[SerializeField]
	private GameObject[] gateOverlays;

	[SerializeField]
	private GameObject gateFooter;

	[SerializeField]
	private GameObject gateFooterLocked;

	[SerializeField]
	private AdvancedButton gateUnlockButton;

	protected Character character;

	protected SkillTreeNodeUI selectedNodeUI;

	protected SkillTreeNode selectedNode;

	protected const int kXPos = 250;

	private SkillTreeNode gateNode;

	public virtual void Populate(SkillTreeNodeUI nodeUI, Character inCharacter)
	{
	}

	public SkillTreeNode GetLockingGateNode()
	{
		return null;
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void UGUI_PurchasedButtonClicked(bool hcShortcut = false)
	{
	}

	public void UGUI_UnlockParentGate()
	{
	}

	public void SetTutorialView()
	{
	}

	public Transform GetIndicatorPosition()
	{
		return null;
	}

	private void TryPurchaseNode(SkillTreeNode targetNode, bool hcShortcut = false)
	{
	}

	protected virtual void SetupPurchaseButton(bool canPurchase, bool hcShortcut = false)
	{
	}

	private void SetupProgressionInfo(bool canPurchase = true)
	{
	}

	private void SendPurchaseRequest(SkillTreeNode targetNode, Currency hcPrice, Currency scOrKeyPrice, Currency skillPointPrice, bool hcShortcut)
	{
	}

	private void OnNodePurchasedCallback(SkillTreeNode targetNode, Currency hcPrice, Currency scOrKeyPrice, Currency skillPointPrice, bool hcShortcut)
	{
	}

	private void SendTutorialPurchase(SkillTreeNode targetNode, Currency hcPrice, Currency scOrKeyPrice, Currency skillPointPrice)
	{
	}

	private bool IsFTUEV2TutorialPurchase()
	{
		return false;
	}
}
