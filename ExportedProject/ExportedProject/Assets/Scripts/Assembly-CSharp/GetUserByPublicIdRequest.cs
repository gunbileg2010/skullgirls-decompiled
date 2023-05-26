using System;

public class GetUserByPublicIdRequest : NetworkRequest
{
	private string publicId;

	private UserServerData userData;

	public GetUserByPublicIdRequest(string publicId)
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
