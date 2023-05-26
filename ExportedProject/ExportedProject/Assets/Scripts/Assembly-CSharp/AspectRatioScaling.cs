using UnityEngine;

public class AspectRatioScaling : MonoBehaviour
{
	[SerializeField]
	private float scale4_3;

	[SerializeField]
	private float scale16_9;

	[SerializeField]
	private bool relativeToCurrentScale;

	private Vector3 baseScale;

	private void Awake()
	{
	}

	private void SetScale()
	{
	}
}
