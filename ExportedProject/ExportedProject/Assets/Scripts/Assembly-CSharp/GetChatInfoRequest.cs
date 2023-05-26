using System;
using System.Collections.Generic;

public class GetChatInfoRequest : NetworkRequest
{
	private bool chatEnabled;

	private string subscribeKey;

	private string publishKey;

	private List<ChatChannelGroup> chatChannelGroups;

	private int idealChannelOccupancy;

	private int maxChannelOccupancy;

	public override void Send(Action callback)
	{
	}

	public bool IsChatEnabled()
	{
		return false;
	}

	public string GetSubscribeKey()
	{
		return null;
	}

	public string GetPublishKey()
	{
		return null;
	}

	public List<ChatChannelGroup> GetChatChannelGroups()
	{
		return null;
	}

	public int GetIdealChannelOccupancy()
	{
		return 0;
	}

	public int GetMaxChannelOccupancy()
	{
		return 0;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
