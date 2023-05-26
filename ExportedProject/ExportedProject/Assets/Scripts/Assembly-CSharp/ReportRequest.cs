using System;

public class ReportRequest : NetworkRequest
{
	private string reason;

	public ReportRequest(string reason)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
