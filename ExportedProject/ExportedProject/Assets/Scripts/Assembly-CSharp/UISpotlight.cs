using UnityEngine;
using UnityEngine.UI;

public class UISpotlight : BaseMeshEffect
{
	[SerializeField]
	private Vector2 position;

	[SerializeField]
	private Vector2 scale;

	[SerializeField]
	private float radius;

	[SerializeField]
	private float attenuation;

	[SerializeField]
	private Vector2 minMaxAlpha;

	private static Material spotlightMaterial;

	private static int _Aspect;

	private static int _Position;

	private static int _Radius;

	private static int _Attenuation;

	private static int _MinMaxAlpha;

	private Image image;

	private float alpha;

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	public override void ModifyMesh(VertexHelper vertexHelper)
	{
	}

	public void SetPosition(Vector2 pos)
	{
	}

	public void SetRadius(float rad)
	{
	}

	public float GetRadius()
	{
		return 0f;
	}

	public void SetScale(Vector2 inScale)
	{
	}

	public void SetAlpha(float alpha)
	{
	}

	private void RefreshImage()
	{
	}
}
