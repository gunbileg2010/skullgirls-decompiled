using System;
using System.Collections;
using System.Collections.Generic;

namespace PubNubAPI
{
	public static class Utility
	{
		public static readonly string PresenceChannelSuffix;

		public static readonly int iOSRequestTimeout;

		public static bool CheckDictionaryForError(Dictionary<string, object> dictionary, string keyName)
		{
			return false;
		}

		public static string ReadMessageFromResponseDictionary(Dictionary<string, object> dictionary, string keyName)
		{
			return null;
		}

		public static bool TryCheckKeyAndParseLong(IDictionary dict, string what, string key, out string log, out long sequenceNumber)
		{
			log = null;
			sequenceNumber = default(long);
			return false;
		}

		public static bool TryCheckKeyAndParseInt(IDictionary dict, string what, string key, out string log, out int val)
		{
			log = null;
			val = default(int);
			return false;
		}

		public static long ValidateTimetoken(string timetoken, bool raiseError)
		{
			return 0L;
		}

		public static string CheckChannelGroup(string channelGroup, bool convertToPresence)
		{
			return null;
		}

		public static List<string> CheckAndAddNameSpace(string nameSpace)
		{
			return null;
		}

		public static void CheckChannelOrChannelGroup(string channel, string channelGroup)
		{
		}

		public static void CheckChannels(string[] channels)
		{
		}

		public static void CheckChannel(string channel)
		{
		}

		public static void CheckMessage(object message)
		{
		}

		public static void CheckString(string message, string what)
		{
		}

		public static void CheckPublishKey(string publishKey)
		{
		}

		public static Guid GenerateGuid()
		{
			return default(Guid);
		}

		public static bool IsPresenceChannel(string channel)
		{
			return false;
		}

		public static bool IsUnsafe(char ch, bool ignoreComma)
		{
			return false;
		}

		private static char ToHex(int ch)
		{
			return '\0';
		}

		public static string EncodeUricomponent(string s, PNOperationType type, bool ignoreComma, bool ignorePercent2fEncode)
		{
			return null;
		}

		public static long TranslateDateTimeToSeconds(DateTime dotNetUTCDateTime)
		{
			return 0L;
		}

		public static long TranslateDateTimeToPubnubUnixNanoSeconds(DateTime dotNetUTCDateTime)
		{
			return 0L;
		}

		public static DateTime TranslatePubnubUnixNanoSecondsToDateTime(long unixNanoSecondTime)
		{
			return default(DateTime);
		}

		public static List<string> CheckKeyAndConvertObjToStringArr(object obj)
		{
			return null;
		}
	}
}
