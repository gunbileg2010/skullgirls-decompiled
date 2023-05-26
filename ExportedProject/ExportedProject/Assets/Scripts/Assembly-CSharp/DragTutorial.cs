using UnityEngine;

public class DragTutorial : MonoBehaviour
{
	[SerializeField]
	private Transform startTransform;

	[SerializeField]
	private Transform targetTransform;

	private AnimatePosition tutorialAnimatePosition;

	private EZAnimateFloat tutorialAnimateAlpha;

	private bool isAnimating;

	public void StartAnimatingTutorial()
	{
	}

	public void StopAnimatingTutorial()
	{
	}

	public bool IsAnimating()
	{
		return false;
	}
}
