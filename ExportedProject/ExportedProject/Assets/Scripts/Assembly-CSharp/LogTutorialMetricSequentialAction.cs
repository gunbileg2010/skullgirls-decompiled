using UnityEngine;

public class LogTutorialMetricSequentialAction : SequentialAction
{
	[SerializeField]
	private TutorialType tutorialType;

	[SerializeField]
	private string eventName;

	protected override void ExecuteAction()
	{
	}
}
