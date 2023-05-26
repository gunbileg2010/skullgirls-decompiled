using System.Collections.Generic;

public class SessionServerData
{
	public string userId;

	public string userToken;

	public bool isGuest;

	public bool isNewUser;

	public SessionServerData()
	{
	}

	public SessionServerData(Dictionary<string, object> dataDict)
	{
	}
}
