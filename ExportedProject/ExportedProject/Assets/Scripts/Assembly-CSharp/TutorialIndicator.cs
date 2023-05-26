using UnityEngine;

public class TutorialIndicator : MonoBehaviour
{
	[SerializeField]
	public Vector2 offset;

	[SerializeField]
	public Vector2 scale;

	public virtual void PointAt(IndicatorTarget target)
	{
	}

	public virtual void PointAt(Transform pointAtTransform, PointDirection pointDirection = PointDirection.Right)
	{
	}
}
