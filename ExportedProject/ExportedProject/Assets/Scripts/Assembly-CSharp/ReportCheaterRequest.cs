using System;
using System.Collections.Generic;

public class ReportCheaterRequest : NetworkRequest
{
	private string reportedPublicId;

	private List<string> reportReasons;

	private ReportType reportType;

	public ReportCheaterRequest(string reportedPublicId, List<string> reportReasons, ReportType reportType)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
