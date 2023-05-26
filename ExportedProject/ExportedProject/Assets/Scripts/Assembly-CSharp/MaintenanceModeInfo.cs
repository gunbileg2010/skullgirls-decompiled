using System.Collections.Generic;

public class MaintenanceModeInfo
{
	private bool enabled;

	private string title;

	private Dictionary<string, object> localizedTitle;

	private string message;

	private Dictionary<string, object> localizedMessages;

	private string buttonLeft;

	private Dictionary<string, object> localizedButtonLeft;

	private string buttonRight;

	private Dictionary<string, object> localizedButtonRight;

	private string detailsUrl;

	private string kDefaultMaintenanceModeTitle;

	private string kDefaultMaintenanceModeMessage;

	private string kDefaultButtonLeft;

	private string kDefaultButtonRight;

	private string kDefaultDetailsUrl;

	private string redirectVersion;

	private string redirectApiUrl;

	private string redirectCdnUrl;

	public MaintenanceModeInfo()
	{
	}

	public MaintenanceModeInfo(Dictionary<string, object> dataDict)
	{
	}

	public bool IsMaintenanceModeEnabled()
	{
		return false;
	}

	public string GetTitle(string localeCode = "en")
	{
		return null;
	}

	public string GetMessage(string localeCode = "en")
	{
		return null;
	}

	public string GetButtonLeftString(string localeCode = "en")
	{
		return null;
	}

	public string GetButtonRightString(string localeCode = "en")
	{
		return null;
	}

	public string GetDetailsUrl()
	{
		return null;
	}

	public string GetRedirectVersion()
	{
		return null;
	}

	public string GetRedirectApiUrl()
	{
		return null;
	}

	public string GetRedirectCdnUrl()
	{
		return null;
	}

	private string GetString(string localeCode, Dictionary<string, object> stringDict, string defaultString)
	{
		return null;
	}
}
