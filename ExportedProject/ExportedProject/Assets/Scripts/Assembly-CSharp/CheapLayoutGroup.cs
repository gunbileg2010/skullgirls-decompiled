using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CheapLayoutGroup : MonoBehaviour
{
	private enum LayoutType
	{
		Horizontal = 0,
		Vertical = 1
	}

	private enum StartingPoint
	{
		First = 0,
		Middle = 1,
		Last = 2
	}

	[SerializeField]
	private LayoutType layoutType;

	[SerializeField]
	private StartingPoint startingPoint;

	[SerializeField]
	private Vector2 padding;

	[SerializeField]
	private bool reversed;

	private void OnEnable()
	{
	}

	public void RefreshLayout()
	{
	}

	private Vector2 CalculateOffset(List<RectTransform> children)
	{
		return default(Vector2);
	}
}
