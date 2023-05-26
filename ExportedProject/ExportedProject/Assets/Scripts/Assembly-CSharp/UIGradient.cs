using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGradient : BaseMeshEffect
{
	[SerializeField]
	private RectTransform.Axis axis;

	[SerializeField]
	private Color firstColor;

	[SerializeField]
	private Color secondColor;

	[SerializeField]
	private bool multiplyGraphicColor;

	[SerializeField]
	private bool resetGradientOnTextLineBreak;

	private Text text;

	protected override void OnEnable()
	{
	}

	public void SetColors(Gradient newGradient)
	{
	}

	public void SetColors(Color32 newTopColor, Color32 newBottomColor)
	{
	}

	public override void ModifyMesh(VertexHelper vh)
	{
	}

	public void ModifyVertices(List<UIVertex> vertexList)
	{
	}
}
