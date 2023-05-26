using System;

public class SetGearLockStateRequest : NetworkRequest
{
	private string backendId;

	private bool isLocked;

	public SetGearLockStateRequest(Gear instance, bool newLockState)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
