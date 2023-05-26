using UnityEngine;
using UnityEngine.UI;

public class UICurtain : MaskableGraphic
{
	public enum Direction
	{
		TopDown = 0,
		BottomUp = 1
	}

	[SerializeField]
	private Direction direction;

	[SerializeField]
	private float numberOfColumns;

	[SerializeField]
	private float t;

	public void SetT(float newT)
	{
	}

	public float GetT()
	{
		return 0f;
	}

	public void SetDirection(Direction newDirection)
	{
	}

	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}
}
