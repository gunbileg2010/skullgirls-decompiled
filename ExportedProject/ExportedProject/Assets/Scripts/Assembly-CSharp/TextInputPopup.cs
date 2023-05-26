using UnityEngine;
using UnityEngine.UI;

public class TextInputPopup : SGUGUIPopup
{
	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private LocalizedUGUIText titleText;

	[SerializeField]
	private LocalizedUGUIText messageText;

	[SerializeField]
	private InputField textInput;

	public override void SetData(PopupData newPopupData)
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	protected override void ButtonPressed(int index)
	{
	}
}
