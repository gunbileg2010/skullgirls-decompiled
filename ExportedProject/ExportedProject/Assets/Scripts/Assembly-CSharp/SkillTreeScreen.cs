using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class SkillTreeScreen : MonoBehaviour
{
	[SerializeField]
	private SkillTreeNodeUI baseNodePrefab;

	[SerializeField]
	private SkillTreeNodeUI SASkillNodePrefab;

	[SerializeField]
	private SkillTreeNodeUI emptyNodePrefab;

	[SerializeField]
	private SkillTreeNodeUI gateNodePrefab;

	[SerializeField]
	protected LocalizedUGUIText nameText;

	[SerializeField]
	protected LocalizedUGUIText variantNameText;

	[SerializeField]
	private LocalizedUGUIText gateUnlockText;

	[SerializeField]
	private LocalizedUGUIText completionText;

	[SerializeField]
	private SkillTree defaultSkillTree;

	[SerializeField]
	private RectTransform nodeContainer;

	[SerializeField]
	private UILineRenderer lineRenderer;

	[SerializeField]
	private UILineRenderer availableLineRenderer;

	[SerializeField]
	private UILineRenderer ownedLineRenderer;

	[SerializeField]
	protected ScrollRect skillTreeScrollRect;

	[SerializeField]
	private UIRectAutoSizer boundsSizer;

	[SerializeField]
	private PinchAndZoom pinchAndZoom;

	[SerializeField]
	private RawImage[] backplateImages;

	[SerializeField]
	private SkillTreeNodeInfoPopup nodeInfoPopup;

	[SerializeField]
	private SuperAbilityInfoPopup superAbilityInfoPopup;

	[SerializeField]
	private Animator fanfareAnimation;

	[SerializeField]
	private LocalizedUGUIText fanfareSkillTypeText;

	[SerializeField]
	private LocalizedUGUIText fanfareSkillNameText;

	[SerializeField]
	private LocalizedUGUIText fanfareActionText;

	[SerializeField]
	private Material diamondAirMaterial;

	[SerializeField]
	private Material diamondWaterMaterial;

	[SerializeField]
	private Material diamondFireMaterial;

	[SerializeField]
	private Material diamondLightMaterial;

	[SerializeField]
	private Material diamondDarkMaterial;

	[SerializeField]
	private Material diamondNeutralMaterial;

	private List<SkillTreeNodeUI> nodeObjects;

	private Character character;

	private VariantCharacterData characterData;

	private SkillTree skillTree;

	private SkillTreeNodeUI selectedNodeUI;

	private SkillTreeNodeUI selectedGateNodeUI;

	private SkillTreeNodeUI superNodeUI;

	private const int kTopBarConfiguration = 1048604;

	private AnimatePosition skillTreePanAnim;

	private List<GameObject> tutorialIndicators;

	private static bool tutorialMode;

	private void Awake()
	{
	}

	public static void SetTutorialMode(bool active)
	{
	}

	public static bool IsTutorialMode()
	{
		return false;
	}

	public void UGUI_BackingPressed()
	{
	}

	public void UGUI_FanfareSkipClicked()
	{
	}

	public Transform GetIndicatorPostion(IndicatorTarget target)
	{
		return null;
	}

	public void PointAtNode(string nodeGuid, List<TutorialIndication> indications)
	{
	}

	private IEnumerator OnStateEntered(IGameState prevState, object context)
	{
		return null;
	}

	private IEnumerator OnStateExited(IGameState nextState)
	{
		return null;
	}

	protected SkillTreeNodeUI GetPrefabForType(SkillTreeNodeType nodeType)
	{
		return null;
	}

	private void BuildSkillTree(Character character)
	{
	}

	private void OnTutorialNodeNodePressed(SkillTreeNodeUI nodeUI)
	{
	}

	private void OnNodePressed(SkillTreeNodeUI nodeUI)
	{
	}

	private void OnSuperNodePressed(SkillTreeNodeUI nodeUI)
	{
	}

	private void SetUpBackButtonCallback(bool clear)
	{
	}

	private void OnNodePurchased(SkillTreeNode purchasedNode)
	{
	}

	private void OnTutorialNodePurchased(SkillTreeNode purchasedNode)
	{
	}

	public SkillTreeNodeUI GetNodeUI(string guid)
	{
		return null;
	}

	private void RefreshTreeUI()
	{
	}

	private void RefreshLineUI()
	{
	}

	private void DeselectNode()
	{
	}

	private void PositionSkillTreeAt(SkillTreeNodeUI node)
	{
	}

	private void TintBackplate()
	{
	}

	private Material GetBackingMaterial(RarityTier tier, Element element = Element.Neutral)
	{
		return null;
	}
}
