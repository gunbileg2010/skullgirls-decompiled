using System;

public class SetCharacterLockStateRequest : NetworkRequest
{
	private string backendId;

	private bool isLocked;

	public SetCharacterLockStateRequest(Character character, bool newLockState)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
