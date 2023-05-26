using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReportAbusePopup : SGUGUIPopup
{
	[Serializable]
	protected struct ReportReason
	{
		public Toggle ReasonToggle;

		public string ServerReasonText;
	}

	[SerializeField]
	private AdvancedButton reportButton;

	[SerializeField]
	protected List<ReportReason> reportReasons;

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void UGUI_ToggleValueChanged(bool isOn)
	{
	}

	protected List<string> GetReasons()
	{
		return null;
	}

	protected void ResetToggles()
	{
	}
}
