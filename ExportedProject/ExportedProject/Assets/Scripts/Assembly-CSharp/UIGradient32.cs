using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGradient32 : BaseMeshEffect
{
	[SerializeField]
	private RectTransform.Axis axis;

	[SerializeField]
	private Color32 topColor;

	[SerializeField]
	private Color32 bottomColor;

	[SerializeField]
	private bool multiplyGraphicColor;

	[SerializeField]
	private bool resetGradientOnTextLineBreak;

	private Text text;

	public void SetColors(Gradient newGradient)
	{
	}

	public void SetColors(Color32[] colors)
	{
	}

	public void SetColors(Color32 newTopColor, Color32 newBottomColor)
	{
	}

	public Color32[] GetColors()
	{
		return null;
	}

	protected override void OnEnable()
	{
	}

	public override void ModifyMesh(VertexHelper vh)
	{
	}

	public void ModifyVertices(List<UIVertex> vertexList)
	{
	}
}
