using UnityEngine;
using UnityEngine.UI;

public class UIGradientMapped : BaseMeshEffect
{
	[SerializeField]
	private Gradient gradient;

	[SerializeField]
	private bool flipGradient;

	[SerializeField]
	private bool tint;

	private const int kGradientTextureWidth = 256;

	private static Color32[] colors;

	private static int _GradientTex;

	private static Material gradientMappedMaterial;

	private static Material gradientMappedPremultiplyMaterial;

	private Material gradientMaterial;

	private Texture2D gradientTexture;

	private bool needsMaterialSetAfterRebuild;

	protected override void Awake()
	{
	}

	protected override void OnDisable()
	{
	}

	public void Update()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void InitMaterial()
	{
	}

	public override void ModifyMesh(VertexHelper vh)
	{
	}

	public void SetGradient(Gradient newGradient, bool copy = true)
	{
	}

	public Image GetImage()
	{
		return null;
	}

	private Texture2D GetGradientTexture()
	{
		return null;
	}

	private void UpdateGradientTexture(bool isMidRebuild = false)
	{
	}

	private void MakeSureGradientTextureExists()
	{
	}
}
