using System;

public class SetTutorialProgressRequest : NetworkRequest
{
	private int progress;

	private TutorialType tutorialType;

	private int abTestGroup;

	private string context;

	public SetTutorialProgressRequest(TutorialType tutorialType, int progress, int abTestGroup, string context = null)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
