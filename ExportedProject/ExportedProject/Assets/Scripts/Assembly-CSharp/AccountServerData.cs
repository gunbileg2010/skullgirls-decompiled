using System.Collections.Generic;

public class AccountServerData
{
	public LoginType loginType;

	public string accountId;

	public bool verified;

	private string accountName;

	public static List<AccountServerData> FromJsonList(List<object> accountsList)
	{
		return null;
	}

	public AccountServerData(LoginType type, string accountId)
	{
	}

	public AccountServerData(Dictionary<string, object> dataDict)
	{
	}

	public void ParseData(Dictionary<string, object> dataDict)
	{
	}

	public string GetDisplayName()
	{
		return null;
	}
}
