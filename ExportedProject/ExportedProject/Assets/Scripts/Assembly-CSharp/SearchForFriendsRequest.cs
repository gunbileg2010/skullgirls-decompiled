using System;
using System.Collections.Generic;

public class SearchForFriendsRequest : NetworkRequest
{
	private string handle;

	private List<FriendInstance> usersFound;

	public SearchForFriendsRequest(string handle)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
