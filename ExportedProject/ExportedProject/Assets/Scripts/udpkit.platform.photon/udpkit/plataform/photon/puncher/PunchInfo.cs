using System.Net;

namespace udpkit.plataform.photon.puncher
{
	internal class PunchInfo
	{
		public IPEndPoint internalAddress;

		public IPEndPoint externalAddress;

		public PunchInfo(string internalIPAddress, int internalPort, IPEndPoint externalAddress)
		{
		}

		public PunchInfo(string punchInfoString)
		{
		}

		public bool IsInternalEqualsExternal()
		{
			return false;
		}

		public bool IsExternalInvalid()
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
