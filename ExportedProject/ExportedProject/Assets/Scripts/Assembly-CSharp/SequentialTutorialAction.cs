using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SequentialTutorialAction : SequentialAction
{
	[SerializeField]
	protected GameObject actionDisplay;

	[SerializeField]
	[TextArea]
	protected string actionPromptText;

	[SerializeField]
	protected List<TutorialIndication> tutorialIndications;

	protected GameObject display;

	protected List<TutorialIndicator> indicators;

	protected Text displayText;

	public override void Execute(Action onComplete)
	{
	}

	protected void SpawnTutorialIndications(Transform overrideTransform = null)
	{
	}

	protected void FixCanvasSorting(GameObject canvasObject)
	{
	}

	protected override void FinishAction()
	{
	}
}
