using System.Collections.Generic;

public static class ChatHelper
{
	private static XsCharacter workingChar;

	public static string GetActivityMessageKeyFromType(ChatActivityType activityType)
	{
		return null;
	}

	public static ChatMessage ConstructActivityMessage(ChatActivityType activityType, Profile profile, string channel, Dictionary<string, object> additionalMetaData)
	{
		return null;
	}

	public static Dictionary<string, object> GetBaseMetadataForCharacter(Character character)
	{
		return null;
	}

	public static void ConstructAndSendCharacterActivityMessageForRewards(List<Reward> rewards, string rewardSource, bool shinyOnly = false)
	{
	}

	public static string FindBestPublicChatChannel(ChatChannelGroup chatSettings, Dictionary<string, int> occupancyCounts, int idealOccupancy, int maxOccupancy)
	{
		return null;
	}

	public static int GetMaxChannelNumber(List<ChatChannelGroup> channelGroups)
	{
		return 0;
	}

	public static int ChannelNameToNumber(string channelName, List<ChatChannelGroup> channelGroups)
	{
		return 0;
	}

	public static string ChannelNumberToName(int channelNumber, List<ChatChannelGroup> channelGroups)
	{
		return null;
	}

	public static ChatMessage ConstructChatMessage(Profile profile, string message, string channel)
	{
		return null;
	}

	public static ChatMessage ConstructChatMessage(string publicId, string handle, float level, Character repCharacter, RiftTier tier, bool isDeveloper, string message, string channel)
	{
		return null;
	}
}
