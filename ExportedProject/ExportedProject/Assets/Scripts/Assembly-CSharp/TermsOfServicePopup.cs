using UnityEngine;
using UnityEngine.UI;

public class TermsOfServicePopup : SGUGUIPopup
{
	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private LocalizedUGUIText descriptionText;

	[SerializeField]
	private LocalizedUGUIText downloadText;

	public override void SetData(PopupData newPopupData)
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void UGUI_TermsOfServicePressed()
	{
	}

	public void UGUI_PrivacyPolicyPressed()
	{
	}

	protected override void ButtonPressed(int index)
	{
	}
}
