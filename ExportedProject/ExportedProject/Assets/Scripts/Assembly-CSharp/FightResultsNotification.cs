using System;
using UnityEngine;
using UnityEngine.UI;

public class FightResultsNotification : MonoBehaviour
{
	[SerializeField]
	private Image icon;

	[SerializeField]
	private LocalizedUGUIText titleText;

	[SerializeField]
	private LocalizedUGUIText infoText;

	[SerializeField]
	private GameObject frameGO;

	[SerializeField]
	private CanvasGroup canvasGroup;

	public void Populate(Sprite iconSprite, string title, string info)
	{
	}

	public void ShowAndHide(float showDelay, float hideDelay)
	{
	}

	public void Show(float delay = 0f)
	{
	}

	public void Hide(float delay = 0f)
	{
	}

	private void ShowInternal(float showDelay, Action<EZAnimation> endDel)
	{
	}

	private void UpdateUI(float value)
	{
	}
}
