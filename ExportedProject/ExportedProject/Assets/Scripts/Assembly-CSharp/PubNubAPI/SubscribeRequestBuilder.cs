using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public class SubscribeRequestBuilder
	{
		public long Timetoken
		{
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public List<string> ChannelsToUse
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public List<string> ChannelGroupsToUse
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected PubNubUnity PubNubInstance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IncludePresenceChannel
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool SubscribeToPresenceChannelOnly
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public SubscribeRequestBuilder(PubNubUnity pn)
		{
		}

		public void WithPresence()
		{
		}

		public void PresenceOnly()
		{
		}

		private void CheckPresenceAndAddSuffix(ref List<string> rawChannels, bool includePresenceChannel, bool subscribeToPresenceChannelOnly)
		{
		}

		public void Execute()
		{
		}

		public void Channels(List<string> channelNames)
		{
		}

		public void SetTimeToken(long timetoken)
		{
		}

		public void ChannelGroups(List<string> channelGroupNames)
		{
		}
	}
}
