using System.Collections;
using UnityEngine;

public class FanfarePopup : SGUGUIPopup
{
	[SerializeField]
	private Animator fanfareAnimation;

	[SerializeField]
	private LocalizedUGUIText fanfareTitle;

	[SerializeField]
	private LocalizedUGUIText fanfareSubtitle;

	[SerializeField]
	private LocalizedUGUIText fanfareBody;

	private Coroutine showFanfareAnimation;

	private bool hasOverrideSFX;

	private bool skipAllowed;

	public override void SetData(PopupData newPopupData)
	{
	}

	public override void Show()
	{
	}

	public void UGUI_FanfareSkipClicked()
	{
	}

	private IEnumerator ShowFanfare()
	{
		return null;
	}
}
