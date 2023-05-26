using UnityEngine;

public class UIRectAutoSizer : MonoBehaviour
{
	[SerializeField]
	private RectTransform targetRectTransform;

	[SerializeField]
	private Vector4 edgeBuffer;

	[SerializeField]
	private bool debug;

	private RectTransform myRectTransform;

	private void Awake()
	{
	}

	public void Refresh()
	{
	}

	public void SetTargetRectTransform(RectTransform target)
	{
	}

	public void SetBuffer(float left, float bottom, float right, float top)
	{
	}

	private void UpdateRectTransform()
	{
	}

	private void FitAllInRect(RectTransform rectTrans, ref Rect rect)
	{
	}

	private void MoveToPointWithoutMovingChildren(Vector3 localPosition)
	{
	}

	public void UpdateAutoSize()
	{
	}
}
