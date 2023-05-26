using System;

namespace ExitGames.Client.Photon
{
	public enum StatusCode
	{
		Connect = 1024,
		Disconnect = 1025,
		Exception = 1026,
		ExceptionOnConnect = 1023,
		SecurityExceptionOnConnect = 1022,
		[Obsolete]
		QueueOutgoingReliableWarning = 1027,
		[Obsolete]
		QueueOutgoingUnreliableWarning = 1029,
		SendError = 1030,
		[Obsolete]
		QueueOutgoingAcksWarning = 1031,
		[Obsolete]
		QueueIncomingReliableWarning = 1033,
		[Obsolete]
		QueueIncomingUnreliableWarning = 1035,
		[Obsolete]
		QueueSentWarning = 1037,
		ExceptionOnReceive = 1039,
		TimeoutDisconnect = 1040,
		[Obsolete]
		DisconnectByServer = 1041,
		DisconnectByServerTimeout = 1041,
		DisconnectByServerUserLimit = 1042,
		DisconnectByServerLogic = 1043,
		DisconnectByServerReasonUnknown = 1044,
		EncryptionEstablished = 1048,
		EncryptionFailedToEstablish = 1049
	}
}
