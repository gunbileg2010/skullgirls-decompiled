using System;

public class GetUnreadMailCountRequest : NetworkRequest
{
	private int unreadCount;

	public override void Send(Action callback)
	{
	}

	public int GetUnreadCount()
	{
		return 0;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
