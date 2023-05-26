using System;
using System.Collections.Generic;

public class GetMailRequest : NetworkRequest
{
	private int page;

	private int count;

	private List<MailServerData> mails;

	public GetMailRequest(int page = 1, int count = 100)
	{
	}

	public override void Send(Action callback)
	{
	}

	public List<MailServerData> GetMails()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
