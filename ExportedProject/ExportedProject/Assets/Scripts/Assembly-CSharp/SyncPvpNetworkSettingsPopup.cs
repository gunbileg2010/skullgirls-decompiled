using UnityEngine;
using UnityEngine.UI;

public class SyncPvpNetworkSettingsPopup : SGUGUIPopup
{
	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private Slider pingLimitSlider;

	[SerializeField]
	private Slider frameDelaySlider;

	[SerializeField]
	private Toggle displayNetworkInfoToggle;

	[SerializeField]
	private Toggle allowRelayServerToggle;

	[SerializeField]
	private PopupData pingLimitInfoPopup;

	[SerializeField]
	private Color[] pingLimitInfoPingColors;

	private bool initializing;

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void UGUI_SetPingLimitIndex(float value)
	{
	}

	public void UGUI_SetFrameDelay(float value)
	{
	}

	public void UGUI_ToggleDisplayNetworkInfo(bool value)
	{
	}

	public void UGUI_ToggleUseRelayServer(bool value)
	{
	}

	public void UGUI_ShowPingLimitInfoPopup()
	{
	}
}
