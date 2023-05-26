using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public sealed class Subscription
	{
		private readonly PubNubUnity PubNubInstance;

		private readonly SafeDictionary<ChannelIdentity, ChannelParameters> channelEntitiesDictionary;

		public bool HasChannelGroups
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool HasPresenceChannels
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool HasChannelsOrChannelGroups
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool HasChannels
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int CurrentSubscribedChannelsCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int CurrentSubscribedChannelGroupsCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public List<ChannelEntity> ChannelsAndChannelGroupsAwaitingConnectCallback
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

		public List<ChannelEntity> AllChannels
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

		public List<ChannelEntity> AllChannelGroups
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

		public List<ChannelEntity> AllSubscribedChannelsAndChannelGroups
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

		public List<ChannelEntity> AllPresenceChannelsOrChannelGroups
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

		public List<ChannelEntity> AllNonPresenceChannelsOrChannelGroups
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

		public string CompiledUserState
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

		public bool ConnectCallbackSent
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public SafeDictionary<ChannelIdentity, ChannelParameters> ChannelEntitiesDictionary => null;

		public Subscription(PubNubUnity pn)
		{
		}

		public void Add(ChannelEntity channelEntity, bool reset)
		{
		}

		public void Add(List<ChannelEntity> channelEntities)
		{
		}

		public bool Delete(ChannelEntity channelEntity)
		{
			return false;
		}

		public void ResetChannelsAndChannelGroupsAndBuildState()
		{
		}

		public Dictionary<string, object> EditUserState(Dictionary<string, object> newUserState, Dictionary<string, object> oldUserState, bool edit)
		{
			return null;
		}

		public bool TryUpdateOrAddUserStateOfEntity(ref ChannelEntity channelEntity, Dictionary<string, object> userState, bool edit)
		{
			return false;
		}

		public void UpdateIsAwaitingConnectCallbacksOfEntity(List<ChannelEntity> channelEntity, bool isAwaitingConnectCallback)
		{
		}

		public void CleanUp()
		{
		}

		public bool TryRemoveDuplicatesCheckAlreadySubscribedAndGetChannels(PNOperationType type, List<string> rawChannels, List<string> rawChannelGroups, bool unsubscribeCheck, out List<ChannelEntity> channelEntities)
		{
			channelEntities = null;
			return false;
		}

		internal bool RemoveDuplicatesCheckAlreadySubscribedAndGetChannelsCommon(PNOperationType type, List<string> channelsOrChannelGroups, bool isChannelGroup, bool unsubscribeCheck, ref List<ChannelEntity> channelEntities)
		{
			return false;
		}

		internal bool CreateChannelEntityAndAddToSubscribe(PNOperationType type, List<string> rawChannels, bool isChannelGroup, bool unsubscribeCheck, ref List<ChannelEntity> channelEntities, PubNubUnity pn)
		{
			return false;
		}
	}
}
