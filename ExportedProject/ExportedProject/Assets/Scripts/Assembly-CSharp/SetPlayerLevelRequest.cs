using System;

public class SetPlayerLevelRequest : NetworkRequest
{
	private UserServerData updatedUser;

	private int level;

	public SetPlayerLevelRequest(int level)
	{
	}

	public override void Send(Action callback)
	{
	}

	public UserServerData GetUpdatedUserServerData()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
