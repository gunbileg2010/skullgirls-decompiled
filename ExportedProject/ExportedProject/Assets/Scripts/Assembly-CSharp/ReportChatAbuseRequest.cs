using System;
using System.Collections.Generic;

public class ReportChatAbuseRequest : NetworkRequest
{
	private string reportedPublicId;

	private List<string> reportReasons;

	private ChatMessage reportedMessage;

	private List<ChatMessage> chatHistory;

	public ReportChatAbuseRequest(string reportedPublicId, List<string> reportReasons, ChatMessage reportedMessage, List<ChatMessage> chatHistory)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
