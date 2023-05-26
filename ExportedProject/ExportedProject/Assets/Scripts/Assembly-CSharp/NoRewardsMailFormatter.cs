using System.Collections.Generic;

public class NoRewardsMailFormatter : MailFormatter
{
	public override string GetBody(string body, Dictionary<string, string> metadata)
	{
		return null;
	}
}
