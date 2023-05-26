using System;

public class FriendRequestActionRequest : NetworkRequest
{
	public enum FriendAction
	{
		Send = 0,
		Cancel = 1,
		Accept = 2,
		Ignore = 3,
		Remove = 4
	}

	private string friendId;

	private FriendAction requestAction;

	private SocialResponseServerData responseData;

	public FriendRequestActionRequest(string friendId, FriendAction requestAction)
	{
	}

	public override void Send(Action callback)
	{
	}

	public SocialResponseServerData GetResponseData()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
