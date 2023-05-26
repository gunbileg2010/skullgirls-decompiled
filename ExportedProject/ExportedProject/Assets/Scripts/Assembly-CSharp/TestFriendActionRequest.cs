using System;
using System.Collections.Generic;

public class TestFriendActionRequest : NetworkRequest
{
	public enum FriendAction
	{
		Send = 0,
		Cancel = 1,
		Accept = 2,
		Ignore = 3,
		Remove = 4
	}

	private string fakeUser;

	private List<string> fakeFriends;

	private FriendAction requestAction;

	public TestFriendActionRequest(string userId, List<string> friendIds, FriendAction actionToDo)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
