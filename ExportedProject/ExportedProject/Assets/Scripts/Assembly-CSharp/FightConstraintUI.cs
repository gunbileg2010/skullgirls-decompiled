using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class FightConstraintUI : MonoBehaviour
{
	[SerializeField]
	private Image tierImage;

	[SerializeField]
	private Sprite[] tierSprites;

	[SerializeField]
	private Image insigniaImage;

	[SerializeField]
	private Image elementImage;

	[SerializeField]
	private Image noImage;

	[SerializeField]
	private GameObject numberGO;

	[SerializeField]
	private Text numberText;

	[SerializeField]
	private Image problemIndicator;

	[SerializeField]
	private Vector2 tooltipPivot;

	private EZAnimation problemIndicatorAnim;

	private List<FightConstraintUI> neighbors;

	public FightConstraint Constraint
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public ContextualPopupItem ContextualPopupItem
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Fight Fight
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetTierConstraint(RarityTier tier, int count)
	{
	}

	public void SetElementConstraint(Element element, int count)
	{
	}

	public void SetBaseCharacterConstraint(BaseCharacterData baseCharacterData, int count)
	{
	}

	public void SetProblemIndicator(bool on)
	{
	}

	public bool HasProblem()
	{
		return false;
	}

	public void OverrideTooltipPivot(Vector2 pivot)
	{
	}

	public void RegisterNeighbors(List<FightConstraintUI> possibleNeighbors)
	{
	}

	public void UGUI_ToggleTooltip()
	{
	}

	public void UGUI_DisplayTooltip()
	{
	}

	public void UGUI_HideTooltip()
	{
	}

	private void UpdateCount(int count)
	{
	}
}
