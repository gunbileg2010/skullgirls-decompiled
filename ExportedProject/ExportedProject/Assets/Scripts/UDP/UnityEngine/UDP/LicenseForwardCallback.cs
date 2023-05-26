namespace UnityEngine.UDP
{
	public class LicenseForwardCallback : AndroidJavaProxy
	{
		private ILicensingListener _listener;

		private const int LICENSED = 1;

		private const int RETRY = 2;

		private const int NOT_LICENSED = 3;

		private const int STORE_NOT_SUPPORT = 4;

		public LicenseForwardCallback(ILicensingListener listener)
			: base((string)null)
		{
		}

		public void allow(int code, string message)
		{
		}

		public void dontAllow(int code, string message)
		{
		}

		public void applicationError(int code, string message)
		{
		}

		private LicensingCode convertLicensingCode(int codeFromLicenseService)
		{
			return default(LicensingCode);
		}

		private LicensingErrorCode convertLicensingErrorCode(int errorCodeFromService)
		{
			return default(LicensingErrorCode);
		}
	}
}
