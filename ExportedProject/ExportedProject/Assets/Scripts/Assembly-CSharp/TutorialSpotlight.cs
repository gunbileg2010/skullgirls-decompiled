using UnityEngine;

public class TutorialSpotlight : TutorialIndicator
{
	[SerializeField]
	private UISpotlight spotlight;

	private Transform pointAtTransform;

	private Vector2 introOffsetDir;

	private float introOffset;

	private float introAlpha;

	private float introRadius;

	private EZAnimateFloat pulseAnim;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public override void PointAt(Transform pointAtTransform, PointDirection pointDirection = PointDirection.Right)
	{
	}
}
