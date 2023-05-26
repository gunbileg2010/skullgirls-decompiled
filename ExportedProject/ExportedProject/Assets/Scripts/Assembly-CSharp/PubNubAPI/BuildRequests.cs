using System;
using System.Collections.Generic;
using System.Text;

namespace PubNubAPI
{
	public static class BuildRequests
	{
		public static Uri BuildRegisterDevicePushRequest(string channel, PNPushType pushType, string pushToken, PubNubUnity pnInstance)
		{
			return null;
		}

		public static Uri BuildRemoveChannelPushRequest(string channel, PNPushType pushType, string pushToken, PubNubUnity pnInstance)
		{
			return null;
		}

		internal static Uri BuildRemoveAllDevicePushRequest(PNPushType pushType, string pushToken, PubNubUnity pnInstance)
		{
			return null;
		}

		public static Uri BuildGetChannelsPushRequest(PNPushType pushType, string pushToken, PubNubUnity pnInstance)
		{
			return null;
		}

		public static Uri BuildUnregisterDevicePushRequest(PNPushType pushType, string pushToken, PubNubUnity pnInstance)
		{
			return null;
		}

		public static Uri BuildPublishRequest(string channel, string message, bool storeInHistory, string metadata, uint messageCounter, int ttl, bool usePost, bool repilicate, PubNubUnity pnInstance)
		{
			return null;
		}

		internal static Uri BuildDeleteMessagesRequest(string channel, long start, long end, PubNubUnity pnInstance)
		{
			return null;
		}

		internal static Uri BuildFetchRequest(string[] channels, long start, long end, uint count, bool reverse, bool includeToken, PubNubUnity pnInstance)
		{
			return null;
		}

		public static Uri BuildHistoryRequest(string channel, long start, long end, uint count, bool reverse, bool includeToken, PubNubUnity pnInstance)
		{
			return null;
		}

		public static Uri BuildHereNowRequest(string channel, string channelGroups, bool showUUIDList, bool includeUserState, PubNubUnity pnInstance)
		{
			return null;
		}

		public static Uri BuildWhereNowRequest(string uuid, PubNubUnity pnInstance)
		{
			return null;
		}

		public static Uri BuildTimeRequest(PubNubUnity pnInstance)
		{
			return null;
		}

		public static Uri BuildSetStateRequest(string channel, string channelGroup, string jsonUserState, string uuid, PubNubUnity pnInstance)
		{
			return null;
		}

		public static Uri BuildGetStateRequest(string channel, string channelGroup, string uuid, PubNubUnity pnInstance)
		{
			return null;
		}

		public static Uri BuildPresenceHeartbeatRequest(string channels, string channelGroups, string channelsJsonState, PubNubUnity pnInstance)
		{
			return null;
		}

		public static Uri BuildLeaveRequest(string channels, string channelGroups, PubNubUnity pnInstance)
		{
			return null;
		}

		public static Uri BuildSubscribeRequest(string channels, string channelGroups, string timetoken, string channelsJsonState, string region, string filterExpr, PubNubUnity pnInstance)
		{
			return null;
		}

		public static Uri BuildAddChannelsToChannelGroupRequest(string[] channels, string nameSpace, string groupName, PubNubUnity pnInstance)
		{
			return null;
		}

		public static Uri BuildRemoveChannelsFromChannelGroupRequest(string[] channels, string nameSpace, string groupName, PubNubUnity pnInstance)
		{
			return null;
		}

		public static Uri BuildGetChannelsForChannelGroupRequest(string nameSpace, string groupName, bool limitToChannelGroupScopeOnly, PubNubUnity pnInstance)
		{
			return null;
		}

		private static StringBuilder AppendAuthKeyToURL(StringBuilder url, string authenticationKey, PNOperationType type)
		{
			return null;
		}

		private static StringBuilder AppendUUIDToURL(StringBuilder url, string uuid, bool firstInQS)
		{
			return null;
		}

		private static StringBuilder AppendPresenceHeartbeatToURL(StringBuilder url, int pubnubPresenceHeartbeatInSeconds)
		{
			return null;
		}

		private static StringBuilder AppendPNSDKVersionToURL(StringBuilder url, string pnsdkVersion, PNOperationType type)
		{
			return null;
		}

		private static StringBuilder AppendLatencyToURL(StringBuilder url, PNOperationType operationType, PNLatencyManager latency)
		{
			return null;
		}

		private static StringBuilder EncodeURL(List<string> urlComponents, PNOperationType type)
		{
			return null;
		}

		private static StringBuilder AddSSLAndOrigin(bool ssl, string origin, StringBuilder url)
		{
			return null;
		}

		private static string SetParametersInOrder(Uri uri)
		{
			return null;
		}

		private static string GenerateSignatureAndAddToURL(PubNubUnity pnInstance, Uri uri, string url)
		{
			return null;
		}

		private static Uri BuildRestApiRequest<T>(List<string> urlComponents, PNOperationType type, string parameters, PubNubUnity pnInstance)
		{
			return null;
		}
	}
}
