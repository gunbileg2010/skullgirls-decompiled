using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LoginScreen : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup loginCanvasGroup;

	[SerializeField]
	private GameObject loginButtonGO;

	[SerializeField]
	private GameObject offlineLoginGO;

	[SerializeField]
	private GameObject editorLoginGO;

	[SerializeField]
	private InputField editorAccessTokenInputField;

	[SerializeField]
	private PopupData languagePickerPopupData;

	[SerializeField]
	private PopupData tosPopupData;

	[SerializeField]
	private PopupData loginOptionsPopupData;

	[SerializeField]
	private CanvasGroup logoCanvasGroup;

	[SerializeField]
	private bool showLogos;

	[SerializeField]
	private bool showLogosInEditor;

	[SerializeField]
	private float logoFadeOutTime;

	[SerializeField]
	private float pauseTime;

	private static bool haveNotShownLogos;

	private static bool acknowledgeSettingsAdjustment;

	private EZAnimateFloat loginAlphaAnim;

	private void Awake()
	{
	}

	public void UGUI_LoginOptionsPressed(bool newUser)
	{
	}

	public void UGUI_LoginEditorPassword()
	{
	}

	public void UGUI_LoginAsOffline()
	{
	}

	private IEnumerator OnStateEntered(IGameState prevState, object context)
	{
		return null;
	}

	private IEnumerator OnStateExited(IGameState nextState)
	{
		return null;
	}

	private void CheckForMaintenanceMode(Action callback)
	{
	}

	private void CheckForForcedUpdate(Action callback)
	{
	}

	private void PerformLoginFlow()
	{
	}

	private void ShowLoginUI(float duration = 0.2f)
	{
	}

	private void HideLoginUI(float duration = 0.2f)
	{
	}

	private void SetLoginAlpha(float alpha, float duration = 0f)
	{
	}

	private IEnumerator DoShowLanguagePicker()
	{
		return null;
	}

	private IEnumerator DoShowToS()
	{
		return null;
	}

	private IEnumerator DoShowIDFA()
	{
		return null;
	}

	private IEnumerator DoShowSettingsAdjustment()
	{
		return null;
	}

	private void OnDownloadConfirmed()
	{
	}

	private void ContinueToGame()
	{
	}

	private void OnLoginSucceeded(AuthenticateRequest authorizeRequest)
	{
	}

	private void OnLoginFailed(LoginType loginType, LoginManager.LoginError error, string errorCode, string errorMessage)
	{
	}

	private void OnLoginStatusChanged(string loginStatus)
	{
	}

	private void HandlePlayerFlaggedForDeletion(Action callback = null)
	{
	}

	private void SendRemoveFlagsForDeletionRequest(Action callback)
	{
	}
}
