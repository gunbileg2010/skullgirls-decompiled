using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SGUGUIPopup : UGUIPopup
{
	protected List<Button> buttons;

	protected List<UnityAction> buttonActions;

	private AudioClip showSfx;

	private EZAnimation moveAnim;

	private EZAnimation backgroundAnim;

	protected override void OnDestroy()
	{
	}

	public override void Show()
	{
	}

	public override void SetData(PopupData newPopupData)
	{
	}

	protected void PlayShowAnim(RectTransform moveTransform, Graphic background, float backgroundAlpha = 0.75f, Action callback = null)
	{
	}

	protected void PlayHideAnim(RectTransform moveTransform, Graphic background, Action callback)
	{
	}

	protected void SetupButtons(ButtonInfo[] buttonInfo, PopupData popupData)
	{
	}

	protected string GetSubstitutedAndLocalizedString(string str, PopupData popupData)
	{
		return null;
	}

	private void StopMoveAnim()
	{
	}

	private void StopBackgroundAnim()
	{
	}
}
