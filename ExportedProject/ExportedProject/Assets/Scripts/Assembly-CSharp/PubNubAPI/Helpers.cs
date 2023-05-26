using System;
using System.Collections.Generic;

namespace PubNubAPI
{
	public static class Helpers
	{
		public static bool CheckRequestTimeoutMessageInError(CustomEventArgs cea)
		{
			return false;
		}

		public static bool TryCheckErrorTypeAndCallback<T>(CustomEventArgs cea, PubNubUnity pnUnity, out PNStatus pnStatus)
		{
			pnStatus = null;
			return false;
		}

		internal static PNStatus CreatePNStatus(PNStatusCategory category, PNErrorData errorData, bool error, PNOperationType operation, List<string> channels, List<string> channelGroups, RequestState pnRequestState, PubNubUnity pnUnity)
		{
			return null;
		}

		public static PNStatus CreatePNStatus(PNStatusCategory category, string errorString, Exception errorException, bool error, PNOperationType operation, List<ChannelEntity> affectedChannels, List<ChannelEntity> affectedChannelGroups, RequestState pnRequestState, PubNubUnity pnUnity)
		{
			return null;
		}

		public static PNStatus CreatePNStatus(PNStatusCategory category, string errorString, Exception errorException, bool error, PNOperationType operation, List<string> channels, List<string> channelGroups, RequestState pnRequestState, PubNubUnity pnUnity)
		{
			return null;
		}

		public static PNStatus CreatePNStatus(PNStatusCategory category, string errorString, Exception errorException, bool error, PNOperationType operation, ChannelEntity channelEntity, RequestState pnRequestState, PubNubUnity pnUnity)
		{
			return null;
		}

		internal static List<string> CreateListOfStringFromListOfChannelEntity(List<ChannelEntity> channelEntities)
		{
			return null;
		}

		internal static PNErrorData CreateErrorData(string errorString, Exception errorException)
		{
			return null;
		}

		public static string GetAllNamesFromChannelEntities(List<ChannelEntity> channelEntities, bool descriptive)
		{
			return null;
		}

		public static string JsonEncodePublishMsg(object originalMessage, string cipherKey, IJsonLibrary jsonPluggableLibrary, PNLoggingMethod pnLog)
		{
			return null;
		}

		public static string GetNamesFromChannelEntities(List<ChannelEntity> channelEntities, bool isChannelGroup)
		{
			return null;
		}

		public static TimetokenMetadata CreateTimetokenMetadata(object timeTokenDataObject, string whichTT, PNLoggingMethod pnLog)
		{
			return null;
		}

		public static List<object> DeserializeAndAddToResult(string jsonString, string multiChannel, IJsonLibrary jsonPluggableLibrary, bool addChannel)
		{
			return null;
		}

		internal static IEnumerable<string> GetDuplicates(List<string> rawChannels)
		{
			return null;
		}

		public static string BuildJsonUserState(Dictionary<string, object> userStateDictionary)
		{
			return null;
		}

		public static ChannelEntity CreateChannelEntity(string channelOrChannelGroupName2, bool isAwaitingConnectCallback, bool isChannelGroup, Dictionary<string, object> userState, PNLoggingMethod pnLog)
		{
			return null;
		}

		public static List<ChannelEntity> CreateChannelEntity(string[] channelOrChannelGroupNames, bool isAwaitingConnectCallback, bool isChannelGroup, Dictionary<string, object> userState, PNLoggingMethod pnLog)
		{
			return null;
		}

		public static string BuildJsonUserState(List<ChannelEntity> listChannelEntities)
		{
			return null;
		}

		public static object DecodeMessage(string cipherKey, object element, PNOperationType pnOperationType, PubNubUnity pnUnity)
		{
			return null;
		}

		public static bool TryAddToSubscribeMessageList(object dictObject, ref List<SubscribeMessage> subscribeMessages, PNLoggingMethod pnLog)
		{
			return false;
		}

		public static List<SubscribeMessage> CreateListOfSubscribeMessage(object message, PNLoggingMethod pnLog)
		{
			return null;
		}
	}
}
