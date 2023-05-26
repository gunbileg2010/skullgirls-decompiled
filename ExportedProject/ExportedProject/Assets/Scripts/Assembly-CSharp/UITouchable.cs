using UnityEngine;
using UnityEngine.UI;

public class UITouchable : Graphic
{
	[SerializeField]
	private bool draw;

	private CanvasGroup canvasGroup;

	public override bool Raycast(Vector2 sp, Camera eventCamera)
	{
		return false;
	}

	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	protected override void OnCanvasGroupChanged()
	{
	}
}
