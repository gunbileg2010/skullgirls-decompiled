using UnityEngine;

public class EZAnimateAnchoredPositionDriver : EZAnimationDriver
{
	[SerializeField]
	private RectTransform from;

	[SerializeField]
	private RectTransform to;

	[SerializeField]
	private Vector3 fromAnchoredPosition;

	[SerializeField]
	private Vector3 toAnchoredPosition;

	protected override EZAnimation CreateAndStart()
	{
		return null;
	}

	private Vector3 GetFrom()
	{
		return default(Vector3);
	}

	private Vector3 GetTo()
	{
		return default(Vector3);
	}
}
