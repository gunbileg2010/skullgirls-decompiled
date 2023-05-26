using UdpKit;

namespace udpkit.plataform.photon.puncher
{
	internal interface IPunchLoadBalancingClient
	{
		bool LocalPlayerIsMasterClient();

		int LocalPlayerID();

		void CallOpRaiseEvent(int targetPlayer, byte messageCode, string message);

		void OnPunchSuccess(int remotePlayerID, UdpEndPoint remoteEndPoint);

		void OnPunchFailed(int remotePlayerID);
	}
}
