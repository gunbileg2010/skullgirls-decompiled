using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PubNubAPI;

public class PubnubChatService : IChatService
{
	private PubNub pubnub;

	private Dictionary<string, Action<bool>> subscribeCallbacks;

	public event Action<ChatMessage> MessageReceived
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Init(string userId, string subKey, string pubKey, string secretKey)
	{
	}

	public void Cleanup()
	{
	}

	public void GetChannelGroupOccupancy(string channelGroupName, Action<bool, Dictionary<string, int>> callback)
	{
	}

	public void GetChannelOccupancy(string channelName, Action<bool, int> callback)
	{
	}

	public void GetChannelHistory(string channelName, int count, Action<bool, List<ChatMessage>> callback)
	{
	}

	public void Subscribe(string channelName, Action<bool> callback)
	{
	}

	public void Unsubscribe(string channelName, Action<bool> callback)
	{
	}

	public void Publish(ChatMessage message, Action<bool> callback)
	{
	}

	public void GetNumberOfChannelsForUser(string publicId, Action<int> callback)
	{
	}

	private void OnChannelEvent(object sender, EventArgs e)
	{
	}

	private void HandleStatusEvent(PNStatus status)
	{
	}

	private void OutputErrorInfo(PNStatus status)
	{
	}
}
