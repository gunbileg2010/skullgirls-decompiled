using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class OptionsScreen : MonoBehaviour
{
	[SerializeField]
	private ToggleGroupRowController sectionToggleController;

	[SerializeField]
	private Toggle accountToggle;

	[SerializeField]
	private Toggle gameplayToggle;

	[SerializeField]
	private Toggle supportToggle;

	[SerializeField]
	private GameObject accountSectionGO;

	[SerializeField]
	private GameObject gameplaySectionGO;

	[SerializeField]
	private GameObject supportSectionGO;

	[SerializeField]
	private LocalizedUGUIText nameText;

	[SerializeField]
	private LocalizedUGUIText publicIdText;

	[SerializeField]
	private Transform copyPublicIdPopupSpawnPos;

	[SerializeField]
	private AccountBindingRow facebookBindingRow;

	[SerializeField]
	private AccountBindingRow googleBindingRow;

	[SerializeField]
	private AccountBindingRow lineBindingRow;

	[SerializeField]
	private AccountBindingRow emailBindingRow;

	[SerializeField]
	private AccountBindingRow appleBindingRow;

	[SerializeField]
	private AccountBindingRow huaweiBindingRow;

	[SerializeField]
	private Color userIdColor;

	[SerializeField]
	private Color linkedAccountNameColor;

	[SerializeField]
	private Color unverifiedEmailColor;

	[SerializeField]
	private Color verifiedEmailColor;

	[SerializeField]
	private GameObject emailOptionsGO;

	[SerializeField]
	private GameObject resendVerificationButtonGO;

	[SerializeField]
	private Slider musicVolume;

	[SerializeField]
	private Slider sfxVolume;

	[SerializeField]
	private Toggle lightingToggle;

	[SerializeField]
	private Toggle superShadowsToggle;

	[SerializeField]
	private GameObject languageSelectGO;

	[SerializeField]
	private LanguagePickerItem languageButtonItem;

	[SerializeField]
	private PopupData languagePickerPopupData;

	[SerializeField]
	private LanguagePickerItem voButtonItem;

	[SerializeField]
	private Toggle chatToggle;

	[SerializeField]
	private Toggle showFightAssistToggle;

	[SerializeField]
	private Toggle reducedFlashingToggle;

	[SerializeField]
	private GameObject resolutionGO;

	[SerializeField]
	private Slider resolutionSlider;

	[SerializeField]
	private Toggle limitFramerateToggle;

	[SerializeField]
	private PopupData fundSettlementPopupData;

	[SerializeField]
	private PopupData accountDeletedSucceededPopupData;

	private ContextualPopupItem copyPublicIdTooltip;

	private void Awake()
	{
	}

	private void OnApplicationPause(bool paused)
	{
	}

	private void OnDisable()
	{
	}

	public void UGUI_ResendVerificationPressed()
	{
	}

	public void UGUI_ChangeEmailPressed()
	{
	}

	public void UGUI_ChangePasswordPressed()
	{
	}

	public void UGUI_CloseEmailOptionsPressed()
	{
	}

	public void UGUI_LanguageButtonPressed()
	{
	}

	public void UGUI_VoButtonPressed()
	{
	}

	public void UGUI_ChatToggled(bool on)
	{
	}

	public void UGUI_ShowFightAssistToggled(bool on)
	{
	}

	public void UGUI_ReduceFlashingToggled(bool on)
	{
	}

	public void UGUI_MusicVolumeChanged(float volume)
	{
	}

	public void UGUI_SFXVolumeChanged(float volume)
	{
	}

	public void UGUI_LightingToggled(bool on)
	{
	}

	public void UGUI_SuperShadowsToggled(bool on)
	{
	}

	public void UGUI_ResolutionChanged(float value)
	{
	}

	public void UGUI_ResolutionChanged()
	{
	}

	public void UGUI_LimitFramerateToggled(bool on)
	{
	}

	public void UGUI_DiscordButtonClicked()
	{
	}

	public void UGUI_FeedbackButtonClicked()
	{
	}

	public void UGUI_AnnouncementsButtonClicked()
	{
	}

	public void UGUI_VideoGuidesButtonClicked()
	{
	}

	public void UGUI_ContactButtonClicked()
	{
	}

	public void UGUI_ViewWiki()
	{
	}

	public void UGUI_PurchaseInfoButtonClicked()
	{
	}

	public void UGUI_RelicOddsButtonClicked()
	{
	}

	public void UGUI_FinishIncompletePurchasesClicked()
	{
	}

	public void UGUI_DebugButtonClicked()
	{
	}

	public void UGUI_CopyPublicId()
	{
	}

	public void UGUI_DeleteAccountButtonClicked()
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

	private void RefreshAccountSectionUI()
	{
	}

	private void PopulateBindingRow(LoginType loginType, AccountBindingRow bindingRow, string linkedAsCopy, ref int rowNumber)
	{
	}

	private void RefreshEmailOptionsUI()
	{
	}

	private void RefreshGameplaySectionUI()
	{
	}

	private void CheckIfEmailVerified()
	{
	}

	private void ShowEmailOptions(bool show)
	{
	}

	private void OnSectionToggleActivated(Toggle toggle)
	{
	}

	private void RefreshLanguageUI()
	{
	}

	private void OnLanguageChanged(Language newLanguage)
	{
	}

	private void ShowPublicIdCopiedTooltip()
	{
	}

	private void HideTooltips()
	{
	}

	private void ShowAccountDeleteSucceededPopup(string message, Action positiveCallback, Action negativeCallback)
	{
	}
}
