using System;

public class FakeOpenGachasRequest : OpenGachasRequest
{
	public FakeOpenGachasRequest(string inGachaGuid, int inAmount)
		: base(null, 0)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void DEBUG_Send(Action callback)
	{
	}
}
