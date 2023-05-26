using System.Collections.Generic;

public class MailFormatter
{
	public virtual string GetSubject(string subject, Dictionary<string, string> metadata)
	{
		return null;
	}

	public virtual string GetBody(string body, Dictionary<string, string> metadata)
	{
		return null;
	}

	protected string SubMetadata(string str, Dictionary<string, string> metadata)
	{
		return null;
	}
}
