using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElementAffiliationUI : MonoBehaviour
{
	[SerializeField]
	private Image elementIcon;

	[SerializeField]
	private Sprite advantageSprite;

	[SerializeField]
	private Sprite disadvantageSprite;

	[SerializeField]
	private List<Image> chevrons;

	[SerializeField]
	private GameObject advantageModifiersAnchor;

	[SerializeField]
	private Transform advantageParent;

	[SerializeField]
	private Transform disadvantageParent;

	[SerializeField]
	private Button tooltipButton;

	[SerializeField]
	private bool isInteractible;

	[SerializeField]
	private MasterPopupData elementsAffiliationInformationPopup;

	private Element characterElementAffiliation;

	private AnimateScale pulsingAnimation;

	private EZAnimation advantageModifiersAnimation;

	private const float advantageModifiersAnimationDeltaY = 6f;

	private void Awake()
	{
	}

	public void ClearAdvantageModifiers()
	{
	}

	public void ClearIcon()
	{
	}

	public void SetIcon(Character character, bool canUseRandom = false)
	{
	}

	public void SetIcon(Element elementAffiliation)
	{
	}

	public void CalculateAdvantageModifiers(Character[] opponents, bool animate = false)
	{
	}

	public void DoPulsingReaction(Character enemy)
	{
	}

	public void StartElementChanged(Action callback = null)
	{
	}

	public void StartPulsingIcon()
	{
	}

	public void StopPulsingIcon()
	{
	}

	public void StartAdvantageModifiersAnimation()
	{
	}

	public void StopAdvantageModifiersAnimation()
	{
	}

	public void SetFade(bool isFaded)
	{
	}

	public void UGUI_DisplayTooltip()
	{
	}

	private void SetChevronValue(int advantage, int disadvantage, bool detailed = false)
	{
	}
}
