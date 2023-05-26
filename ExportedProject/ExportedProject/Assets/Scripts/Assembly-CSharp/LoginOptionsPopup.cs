using UnityEngine;
using UnityEngine.UI;

public class LoginOptionsPopup : SGUGUIPopup
{
	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private LocalizedUGUIText headerText;

	[SerializeField]
	private string newUserHeaderLocKey;

	[SerializeField]
	private string existingUserHeaderLocKey;

	[SerializeField]
	private LocalizedUGUIText socialInfoText;

	[SerializeField]
	private string newUserSocialInfoLocKey;

	[SerializeField]
	private string existingUserSocialInfoLocKey;

	[SerializeField]
	private GameObject offlineLoginGO;

	[SerializeField]
	private GameObject appleLoginGO;

	[SerializeField]
	private RectTransform googleButtonTransform;

	[SerializeField]
	private RectTransform facebookButtonTransform;

	[SerializeField]
	private GameObject huaweiButtonGO;

	[SerializeField]
	private RectTransform newUserGuestLoginGroup;

	[SerializeField]
	private RectTransform existingUserGuestLoginGroup;

	private const float kWaitToCallLoginSeconds = 0.4f;

	private bool loginAsNewUser;

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void UGUI_SkullgirlsLoginButtonPressed()
	{
	}

	public void UGUI_LINELoginButtonPressed()
	{
	}

	public void UGUI_FacebookLoginButtonPressed()
	{
	}

	public void UGUI_GoogleLoginButtonPressed()
	{
	}

	public void UGUI_GuestLoginButtonPressed()
	{
	}

	public void UGUI_OfflineLoginButtonPressed()
	{
	}

	public void UGUI_AppleLoginButtonPressed()
	{
	}

	public void UGUI_HuaweiLoginButtonPressed()
	{
	}
}
