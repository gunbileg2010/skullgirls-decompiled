namespace PubNubAPI
{
	public enum PNOperationType
	{
		PNSubscribeOperation = 0,
		PNPresenceOperation = 1,
		PNUnsubscribeOperation = 2,
		PNPresenceUnsubscribeOperation = 3,
		PNPublishOperation = 4,
		PNFireOperation = 5,
		PNLeaveOperation = 6,
		PNHistoryOperation = 7,
		PNDeleteMessagesOperation = 8,
		PNFetchMessagesOperation = 9,
		PNWhereNowOperation = 10,
		PNHeartbeatOperation = 11,
		PNPresenceHeartbeatOperation = 12,
		PNSetStateOperation = 13,
		PNGetStateOperation = 14,
		PNAddChannelsToGroupOperation = 15,
		PNRemoveChannelsFromGroupOperation = 16,
		PNChannelGroupsOperation = 17,
		PNRemoveGroupOperation = 18,
		PNChannelsForGroupOperation = 19,
		PNPushNotificationEnabledChannelsOperation = 20,
		PNAddPushNotificationsOnChannelsOperation = 21,
		PNRemovePushNotificationsFromChannelsOperation = 22,
		PNRemoveAllPushNotificationsOperation = 23,
		PNTimeOperation = 24,
		PNHereNowOperation = 25
	}
}
