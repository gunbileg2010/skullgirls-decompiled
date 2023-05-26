using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public struct ChannelIdentity
	{
		public string ChannelOrChannelGroupName
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsChannelGroup
		{
			[CompilerGenerated]
			readonly get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsPresenceChannel
		{
			[CompilerGenerated]
			readonly get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ChannelIdentity(string channelOrChannelGroupName, bool isChannelGroup, bool isPresenceChannel)
		{
		}
	}
}
