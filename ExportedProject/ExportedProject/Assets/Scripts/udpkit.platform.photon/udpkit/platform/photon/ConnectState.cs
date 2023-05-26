namespace udpkit.platform.photon
{
	internal enum ConnectState
	{
		Idle = 0,
		Connected = 1,
		Refused = 2,
		JoinRoomPending = 3,
		JoinRoomFailed = 4,
		DisconnectPending = 5,
		DirectPending = 6,
		DirectFailed = 7,
		DirectSuccess = 8,
		RelayPending = 9,
		RelayFailed = 10,
		RelaySuccess = 11
	}
}
