namespace PubNubAPI
{
	public enum PNStatusCategory
	{
		PNUnknownCategory = 0,
		PNAcknowledgmentCategory = 1,
		PNAccessDeniedCategory = 2,
		PNTimeoutCategory = 3,
		PNNetworkIssuesCategory = 4,
		PNConnectedCategory = 5,
		PNReconnectedCategory = 6,
		PNDisconnectedCategory = 7,
		PNUnexpectedDisconnectCategory = 8,
		PNCancelledCategory = 9,
		PNBadRequestCategory = 10,
		PNMalformedFilterExpressionCategory = 11,
		PNMalformedResponseCategory = 12,
		PNDecryptionErrorCategory = 13,
		PNTLSConnectionFailedCategory = 14,
		PNTLSUntrustedCertificateCategory = 15,
		PNRequestMessageCountExceededCategory = 16,
		PNReconnectionAttemptsExhausted = 17
	}
}
