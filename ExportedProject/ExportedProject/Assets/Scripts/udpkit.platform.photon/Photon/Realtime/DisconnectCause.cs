using System;

namespace Photon.Realtime
{
	public enum DisconnectCause
	{
		None = 0,
		ExceptionOnConnect = 1,
		Exception = 2,
		ServerTimeout = 3,
		[Obsolete]
		DisconnectByServer = 3,
		ClientTimeout = 4,
		[Obsolete]
		TimeoutDisconnect = 4,
		DisconnectByServerLogic = 5,
		DisconnectByServerReasonUnknown = 6,
		InvalidAuthentication = 7,
		CustomAuthenticationFailed = 8,
		AuthenticationTicketExpired = 9,
		MaxCcuReached = 10,
		[Obsolete]
		DisconnectByServerUserLimit = 10,
		InvalidRegion = 11,
		OperationNotAllowedInCurrentState = 12,
		DisconnectByClientLogic = 13
	}
}
