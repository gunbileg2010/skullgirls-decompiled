using UnityEngine;
using UnityEngine.UI;

public class ChangeHandlePopup : SGUGUIPopup
{
	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private InputField handleInput;

	[SerializeField]
	private GameObject cancelButtonGO;

	[SerializeField]
	private AdvancedButton confirmButton;

	[SerializeField]
	private PopupData dynamicNamePopupData;

	private bool clearTextInputOnHide;

	private bool needToPayForChange;

	public override void SetData(PopupData newPopupData)
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public override void Back()
	{
	}

	public void UGUI_OnInputChanged(string value)
	{
	}

	public void UGUI_ConfirmPressed()
	{
	}

	public void UGUI_CancelPressed()
	{
	}

	private void ShowSuccess(string handle)
	{
	}

	private void ShowInvalidContent()
	{
	}

	private void Requeue()
	{
	}
}
