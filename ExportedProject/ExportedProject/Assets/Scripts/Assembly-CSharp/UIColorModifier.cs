using UnityEngine;
using UnityEngine.UI;

public class UIColorModifier : BaseMeshEffect
{
	[SerializeField]
	private Color color;

	[SerializeField]
	private UIColorModifier parent;

	public override void ModifyMesh(VertexHelper vh)
	{
	}

	public void SetColor(Color color)
	{
	}

	public Color GetColor()
	{
		return default(Color);
	}

	public void ForceRefresh()
	{
	}
}
