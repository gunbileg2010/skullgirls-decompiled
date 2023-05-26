using System;

public class SetNodeModifierLockStateRequest : NetworkRequest
{
	private string backendId;

	private bool isLocked;

	public SetNodeModifierLockStateRequest(CollectibleNodeModifier instance, bool newLockState)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
