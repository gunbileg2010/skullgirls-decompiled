using System;
using UnityEngine;

[Serializable]
public class TutorialIndication
{
	public IndicatorTarget target;

	public TutorialIndicator indicatorPrefab;

	public Vector2 offset;

	public Vector2 scale;

	public int sortingOrder;
}
