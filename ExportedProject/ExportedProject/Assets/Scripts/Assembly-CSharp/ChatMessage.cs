using System.Collections.Generic;

public class ChatMessage
{
	public string channel;

	public ChatMessageType type;

	public long timestamp;

	public string publicId;

	public string handle;

	public bool isDeveloper;

	public string message;

	public RiftTier tier;

	public Dictionary<string, object> metaData;

	public bool IsValid()
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public XsProfile GetProfile()
	{
		return null;
	}

	public Dictionary<string, object> ToDictionary(bool includeMetadata = true)
	{
		return null;
	}

	public static ChatMessage FromDictionary(string channelName, Dictionary<string, object> payload)
	{
		return null;
	}
}
