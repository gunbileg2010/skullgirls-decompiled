using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public class SetStateRequestBuilder : PubNubNonSubBuilder<SetStateRequestBuilder, PNSetStateResult>, IPubNubNonSubscribeBuilder<SetStateRequestBuilder, PNSetStateResult>
	{
		private List<ChannelEntity> ChannelEntities;

		private string uuid
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

		private Dictionary<string, object> UserState
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

		public SetStateRequestBuilder(PubNubUnity pn)
		{
			((PubNubNonSubBuilder<, >)(object)this)._002Ector((PubNubUnity)null, default(PNOperationType));
		}

		public void UUID(string uuidToSetState)
		{
		}

		public void State(Dictionary<string, object> userState)
		{
		}

		public void Channels(List<string> channelNames)
		{
		}

		public void ChannelGroups(List<string> channelGroupNames)
		{
		}

		public void Async(Action<PNSetStateResult, PNStatus> callback)
		{
		}

		protected override void RunWebRequest(QueueManager qm)
		{
		}

		internal bool UpdateOrAddUserStateOfEntity(string channel, bool isChannelGroup, Dictionary<string, object> userState, bool edit, bool isForOtherUUID, ref List<ChannelEntity> channelEntities)
		{
			return false;
		}

		internal bool UpdateOrAddUserStateOfEntities(List<string> channelsOrChannelGroups, bool isChannelGroup, Dictionary<string, object> userState, bool edit, bool isForOtherUUID, ref List<ChannelEntity> channelEntities, ref bool stateChanged)
		{
			return false;
		}

		internal bool CheckAndAddExistingUserState(List<string> channels, List<string> channelGroups, Dictionary<string, object> userState, bool edit, string uuid, string sessionUUID, out List<ChannelEntity> channelEntities)
		{
			channelEntities = null;
			return false;
		}

		protected override void CreatePubNubResponse(object deSerializedResult, RequestState requestState)
		{
		}
	}
}
