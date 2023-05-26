namespace UnityEngine.UDP
{
	public interface ILicensingListener
	{
		void allow(LicensingCode code, string message);

		void dontAllow(LicensingCode code, string message);

		void applicationError(LicensingErrorCode errorCode, string message);
	}
}
