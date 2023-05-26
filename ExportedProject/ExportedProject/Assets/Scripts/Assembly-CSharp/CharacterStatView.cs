using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CharacterStatView : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private LocalizedUGUIText statTypeText;

	[SerializeField]
	private LocalizedUGUIText statValueText;

	[SerializeField]
	private LocalizedUGUIText upgradedStatTypeText;

	[SerializeField]
	private LocalizedUGUIText upgradedStatValueText;

	[SerializeField]
	private GameObject statLevelGO;

	[SerializeField]
	private LocalizedUGUIText statLevelText;

	[SerializeField]
	private GameObject upgradedStatLevelGO;

	[SerializeField]
	private LocalizedUGUIText upgradedStatLevelText;

	[SerializeField]
	private StatType statType;

	[SerializeField]
	private bool showTooltip;

	[SerializeField]
	private RectTransform upgradedStatTypeRectTransform;

	[SerializeField]
	private Image arrowImage;

	[SerializeField]
	private Text dashText;

	[SerializeField]
	private UIGradient statLabelGradient;

	[SerializeField]
	private UIGradient statValueGradient;

	[SerializeField]
	private UIGradient upgradedStatLabelGradient;

	[SerializeField]
	private UIGradient upgradeStatValueGradient;

	[SerializeField]
	private Animation upgradedStatLabelAnimation;

	[SerializeField]
	private Animation upgradedStatValueAnimation;

	private ContextualPopupItem popup;

	private StatManager.StatWrapper _wrapper;

	private StatManager.StatWrapper _upgradedWrapper;

	private Fixed lastSeenValue;

	private StatType upgradedStatType;

	private StatManager.StatWrapper wrapper => null;

	private StatManager.StatWrapper upgradedWrapper => null;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void Populate(Fixed value, Color color)
	{
	}

	public void PopulateWithUpdateCheck(Fixed value, Color unchangedColor, Color changedColor)
	{
	}

	public void Populate(Fixed baseValue, Fixed incrementValue, Color defaultColor, Color deltaColor)
	{
	}

	public void Populate(CharacterStats stats, Color color)
	{
	}

	public void PopulateUpgradeView(Stat stat, int upgradeLevel, Color currentColor, Color upgradeColor)
	{
	}

	public void PopulateRerollStatView(Stat stat, Color color)
	{
	}

	public void PopulateRerollResultsView(Stat stat, Stat upgradedStat, bool isRerolledStat = false)
	{
	}

	public void SetStatGradientActive(bool active, Color topColor, Color bottomColor, Color textBaseColor)
	{
	}

	public void SetUpgradedStatGradientActive(bool active, Color topColor, Color bottomColor, Color textBaseColor)
	{
	}

	public void SetStatType(StatType statType)
	{
	}

	public StatType GetStatType()
	{
		return default(StatType);
	}

	public void SetStatLevel(int level)
	{
	}

	public void SetUpgradedStatLevel(int level)
	{
	}

	private void SetupLabel()
	{
	}

	private void SetupUpgradedStatLabel()
	{
	}

	private void SetupGradientColorsForStats(bool active, UIGradient labelGradient, UIGradient valueGradient, Color topColor, Color bottomColor)
	{
	}

	private void PlayUpgradedStatAnimation()
	{
	}

	private void StopUpgradedStatAnimation()
	{
	}
}
