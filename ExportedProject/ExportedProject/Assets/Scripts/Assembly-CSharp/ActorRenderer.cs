using System;
using System.IO;
using UnityEngine;

public class ActorRenderer : MonoBehaviour
{
	private static Material actorMaterial;

	private static Material actorShadowMaterial;

	private Actor actor;

	private FX32Image fx32Image;

	private Transform cachedTransform;

	private ActorData actorData;

	private ActorMesh mainMesh;

	private ActorMesh mainMaskMesh;

	private int mainMaskMeshRenderQueue;

	private ActorMesh shadowMesh;

	private int paletteIndex;

	private Texture2D paletteTexture;

	private float alphaOverride;

	private ActorLayer displayLayer;

	private ActorLayer overrideDisplayLayer;

	private AniFrame currentBackFrame;

	private AniFrame currentMainFrame;

	private AniFrame currentFrontFrame;

	private Action readyToRenderAction;

	private bool useLighting;

	private EZAnimateFloat alphaAnim;

	private void Awake()
	{
	}

	public void Init(ActorData actorData)
	{
	}

	public void End()
	{
	}

	public void SubmitToRender(AniFrame mainFrame, AniFrame backFrame = null, AniFrame frontFrame = null)
	{
	}

	public void SetRenderQueue(int renderQueue)
	{
	}

	public void SetMaskRenderQueue(int maskRenderQueue)
	{
	}

	public void SetShadowRenderQueue(int shadowRenderQueue)
	{
	}

	public void SetPaletteIndex(int index)
	{
	}

	public void UpdateMaterialPaletteProperties()
	{
	}

	public int GetPaletteIndex()
	{
		return 0;
	}

	public void SetTargetColorTint(Color color, float time = 0.5f, bool tintChildren = true)
	{
	}

	public void SetLineColorTint(Color color)
	{
	}

	public Color GetTargetColorTint()
	{
		return default(Color);
	}

	public void SetAlphaOverride(float alpha, float duration = 0f)
	{
	}

	public void SetDisplayLayer(ActorLayer newDisplayLayer)
	{
	}

	public void SetOverrideDisplayLayer(ActorLayer newOverrideDisplayLayer)
	{
	}

	public ActorLayer GetDisplayLayer()
	{
		return default(ActorLayer);
	}

	public Bounds GetRenderBounds()
	{
		return default(Bounds);
	}

	public PicType GetCurrentAniFrameDiffPicType()
	{
		return default(PicType);
	}

	public void SaveState(BinaryWriter writer)
	{
	}

	public void LoadState(BinaryReader reader)
	{
	}

	private void OnReadyToRender()
	{
	}

	private float GetAlpha()
	{
		return 0f;
	}

	private void RenderPaletteFX()
	{
	}

	private void ApplyPaletteEffectByName(uint effectName, Actor actorToUse, ActorData actorDataWithPaletteData = null, bool useSelfEffect2Count = false)
	{
	}

	private void CreateMaskMesh()
	{
	}

	private AniFrame GetCurrentFrameByLayer(FrameLayer layer)
	{
		return null;
	}
}
