using UnityEngine;
using UnityEngine.UI;

public class SGAccountPopup : SGUGUIPopup
{
	public const string kAccountIdEditorKey = "sgPasswordAccountId";

	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private LocalizedUGUIText title;

	[SerializeField]
	private LocalizedUGUIText description;

	[SerializeField]
	private LocalizedUGUIText warning;

	[SerializeField]
	private GameObject warningGO;

	[SerializeField]
	private GameObject loginOptionsGO;

	[SerializeField]
	private InputField emailInput;

	[SerializeField]
	private InputField passwordInput;

	[SerializeField]
	private InputField verifyPasswordInput;

	public static PasswordLoginData loginData;

	private SGAccountPopupData accountPopupData;

	private SGAccountPopupData prevAccountPopupData;

	public override void SetData(PopupData newPopupData)
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void UGUI_CancelPressed()
	{
	}

	public void UGUI_ForgotPasswordPressed()
	{
	}

	public void UGUI_CreateAccountPressed()
	{
	}

	private void SetupButtonCallbacks()
	{
	}

	private void Login(bool createNewUser)
	{
	}

	private void BindAccount()
	{
	}

	private void CreateAccount()
	{
	}

	private void ForgotPassword()
	{
	}

	private void ChangeEmail()
	{
	}

	private bool CredentialsAreValidFormat(bool checkEmail, bool checkPassword)
	{
		return false;
	}

	private void ShowError(string message)
	{
	}

	private void GoBackToLoginPopup()
	{
	}

	private void Requeue()
	{
	}
}
