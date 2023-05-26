using UnityEngine;

public class AspectRatioPositionAdjustment : MonoBehaviour
{
	[SerializeField]
	private Vector3 position4_3;

	[SerializeField]
	private Vector3 position16_9;

	[SerializeField]
	private bool relativeToCurrentPosition;

	private Vector3 startingPosition;

	private void Awake()
	{
	}

	private void SetPosition()
	{
	}
}
