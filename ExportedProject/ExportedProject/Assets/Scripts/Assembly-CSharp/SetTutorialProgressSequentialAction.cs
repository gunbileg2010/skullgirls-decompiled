using UnityEngine;

public class SetTutorialProgressSequentialAction : SequentialAction
{
	[SerializeField]
	private TutorialType tutorialType;

	[SerializeField]
	private int progress;

	protected override void ExecuteAction()
	{
	}
}
