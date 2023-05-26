using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class TextButton : Button, ICanvasRaycastFilter
{
	public TextWithHref targetText;

	private int hoverId;

	private UITouchable touchable;

	protected override void Start()
	{
	}

	protected override void OnDestroy()
	{
	}

	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return false;
	}

	private void OnHrefsChanged()
	{
	}

	protected override void DoStateTransition(SelectionState state, bool instant)
	{
	}
}
