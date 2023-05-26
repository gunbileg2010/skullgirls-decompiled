using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConsumablesPickerPopup : SGUGUIPopup
{
	[SerializeField]
	private RewardScrollView rewardsScrollView;

	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private LocalizedUGUIText headerText;

	[SerializeField]
	private Button closeButton;

	private List<GameObject> tutorialIndicators;

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void PointAtXPConsumable(int consumableIndex, List<TutorialIndication> indications)
	{
	}

	public void DisableButtons(bool close, List<int> consumableButtonIndexes)
	{
	}

	public void SetTutorialIndicatorsActive(bool active)
	{
	}

	private void OnPreStateChanged(string oldState, string newState)
	{
	}
}
