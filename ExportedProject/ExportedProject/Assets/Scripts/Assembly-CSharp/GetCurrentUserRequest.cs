using System;

public class GetCurrentUserRequest : NetworkRequest
{
	private UserServerData userData;

	private FullUserDataType depthFlags;

	public GetCurrentUserRequest(FullUserDataType depthFlags)
	{
	}

	public override void Send(Action callback)
	{
	}

	public UserServerData GetUserData()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
