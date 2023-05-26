using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AspectRatioGridZoom : MonoBehaviour
{
	[SerializeField]
	private List<GridLayoutGroup> grids;

	[SerializeField]
	private float scale4_3;

	[SerializeField]
	private float scale16_9;

	[SerializeField]
	private int maxRows;

	[SerializeField]
	private int minRows;

	[SerializeField]
	private int defaultRows;

	[SerializeField]
	private float transitionLength;

	private int currentRows;

	private IEnumerator scaleGrid;

	private void Awake()
	{
	}

	public void ZoomIn()
	{
	}

	public void ZoomOut()
	{
	}

	public bool IsFullyZoomedIn()
	{
		return false;
	}

	public bool IsFullyZoomedOut()
	{
		return false;
	}

	private void UpdateGridZoom(int numRows, float duration = 0f)
	{
	}

	private IEnumerator ScaleGrid(Vector3 targetScale, float duration)
	{
		return null;
	}
}
