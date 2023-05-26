using UnityEngine;
using UnityEngine.UI;

public class DebugServerSection : MonoBehaviour
{
	[SerializeField]
	private Text bundleIdText;

	[SerializeField]
	private Text backendNameText;

	[SerializeField]
	private Text backendUrlText;

	[SerializeField]
	private Dropdown environmentSelectDropdown;

	[SerializeField]
	private InputField customServerUrlInput;

	[SerializeField]
	private Toggle rememberConfigToggle;

	[SerializeField]
	private Text connectionDebugText;

	[SerializeField]
	private Toggle allowPrivateConnectionToggle;

	[SerializeField]
	private Toggle allowPublicConnectionToggle;

	[SerializeField]
	private Toggle allowRelayConnectionToggle;

	private void OnEnable()
	{
	}

	public void UGUI_EnvironmentDropdownChanged(int value)
	{
	}

	public void UGUI_OverrideServerButtonClicked()
	{
	}

	public void UGUI_ClearServerOverrideButtonClicked()
	{
	}

	public void UGUI_RememberToggleChanged(bool isOn)
	{
	}

	public void UGUI_AllowPrivateConnectionChanges(bool isOn)
	{
	}

	public void UGUI_AllowPublicConnectionChanges(bool isOn)
	{
	}

	public void UGUI_AllowRelayConnectionChanges(bool isOn)
	{
	}

	private void RefreshBackendInfoText()
	{
	}

	private void RefreshBackendDropdown()
	{
	}

	private void RefreshRememberConfig()
	{
	}
}
