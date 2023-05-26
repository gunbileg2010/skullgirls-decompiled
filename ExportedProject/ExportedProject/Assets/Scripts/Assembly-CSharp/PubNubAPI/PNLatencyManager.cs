using System;
using UnityEngine;

namespace PubNubAPI
{
	public sealed class PNLatencyManager : MonoBehaviour
	{
		private float time;

		private float publish;

		private float presence;

		private float channelGroups;

		private float history;

		private float mobilePush;

		private SafeDictionary<long, float> TimeLatency;

		private SafeDictionary<long, float> PublishLatency;

		private SafeDictionary<long, float> PresenceLatency;

		private SafeDictionary<long, float> ChannelGroupsLatency;

		private SafeDictionary<long, float> HistoryLatency;

		private SafeDictionary<long, float> MobilePushLatency;

		private static readonly DateTime epoch;

		private bool RunUpdateLatencyLoop;

		private const float timerConst = 1f;

		private float timer;

		public float Time
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Publish
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Presence
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ChannelGroups
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float History
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float MobilePush
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public void CleanUp()
		{
		}

		public DateTime FromUnixTime2(long unixTime)
		{
			return default(DateTime);
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateLatency()
		{
		}

		private void UpdateLatency(ref SafeDictionary<long, float> dict, long t, ref float f, string name)
		{
		}

		public void StoreLatency(long startTime, long endTime, PNOperationType operationType)
		{
		}
	}
}
