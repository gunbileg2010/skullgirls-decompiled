using UnityEngine;

public class FanfarePopupData : SGUGUIPopupData
{
	[SerializeField]
	private string title;

	[SerializeField]
	private string subtitle;

	[SerializeField]
	private string body;

	[SerializeField]
	private bool skipAllowed;

	public string GetTitle()
	{
		return null;
	}

	public string GetSubtitle()
	{
		return null;
	}

	public string GetBody()
	{
		return null;
	}

	public void SetTitle(string title)
	{
	}

	public void SetSubtitle(string subtitle)
	{
	}

	public void SetBody(string body)
	{
	}

	public bool IsSkipAllowed()
	{
		return false;
	}

	public void SetSkipAllowed(bool skipAllowed)
	{
	}
}
