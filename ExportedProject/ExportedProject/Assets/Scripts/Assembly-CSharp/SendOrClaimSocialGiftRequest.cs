using System;

public class SendOrClaimSocialGiftRequest : NetworkRequest
{
	private string friendId;

	private bool isSending;

	private SocialResponseServerData responseData;

	public SendOrClaimSocialGiftRequest(string friendId, bool isSending)
	{
	}

	public override void Send(Action callback)
	{
	}

	public SocialResponseServerData GetResponseData()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
