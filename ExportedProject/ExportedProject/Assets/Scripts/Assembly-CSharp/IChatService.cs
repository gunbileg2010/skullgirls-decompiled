using System;
using System.Collections.Generic;

public interface IChatService
{
	event Action<ChatMessage> MessageReceived;

	void Init(string userId, string subKey, string pubKey, string secretKey);

	void Cleanup();

	void GetChannelGroupOccupancy(string channelGroupName, Action<bool, Dictionary<string, int>> callback);

	void GetChannelOccupancy(string channelName, Action<bool, int> callback);

	void GetChannelHistory(string channelName, int count, Action<bool, List<ChatMessage>> callback);

	void Subscribe(string channelName, Action<bool> callback);

	void Unsubscribe(string channelName, Action<bool> callback);

	void Publish(ChatMessage message, Action<bool> callback);

	void GetNumberOfChannelsForUser(string publicId, Action<int> callback);
}
