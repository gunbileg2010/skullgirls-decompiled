using System;
using System.Collections.Generic;
using UnityEngine;

public class UserReportManager : MonoBehaviour
{
	private Dictionary<ReportType, HashSet<string>> reportedUsers;

	public void ReportChatAbuse(string reportedPublicId, List<string> reasons, ChatMessage message, List<ChatMessage> chatHistory, Action<bool> callback)
	{
	}

	public void ReportCheating(string reportedPublicId, List<string> reasons, ReportType reportType, Action<bool> callback)
	{
	}

	public bool HasUserBeenReported(string userPublicId, ReportType reportType)
	{
		return false;
	}

	private void SendReportRequest(string reportedPublicId, ReportType reportType, NetworkRequest request, Action<bool> callback)
	{
	}
}
