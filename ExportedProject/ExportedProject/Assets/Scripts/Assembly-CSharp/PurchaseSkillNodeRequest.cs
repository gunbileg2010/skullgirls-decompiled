using System;

public class PurchaseSkillNodeRequest : NetworkRequest
{
	private string characterBackendId;

	private string nodeGuid;

	private bool shortcut;

	public PurchaseSkillNodeRequest(string characterBackendId, string nodeGuid, bool shortcut = false)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
