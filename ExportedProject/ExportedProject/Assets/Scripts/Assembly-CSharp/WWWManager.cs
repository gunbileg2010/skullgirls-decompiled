public class WWWManager
{
	private string smtpUrl;

	private int smtpPort;

	private string smtpUsername;

	private string smtpPassword;

	public void SetSendMailSmtpCredentials(string smtpUrl, int smtpPort, string smtpUsername, string smtpPassword)
	{
	}

	public void SendEmail(string fromAddress, string toAddress, string subject, string body, string[] attachmentFilePaths = null)
	{
	}

	public void OpenEmailClient(string toAddress, string subject, string body)
	{
	}

	public void OpenUrl(string url)
	{
	}

	public void OpenStore(string url)
	{
	}

	private string URLFullEncode(string val)
	{
		return null;
	}
}
