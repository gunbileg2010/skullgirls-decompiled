using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public static class HttpsHelper
{
	public static void InitHttpsValidation()
	{
	}

	public static bool MyRemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		return false;
	}
}
