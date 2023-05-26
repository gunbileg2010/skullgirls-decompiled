using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ActorMesh : MonoBehaviour
{
	public static Fixed3 superFlashVals;

	private static GameObjectPool<ActorMesh> actorMeshPool;

	private MeshFilter meshFilter;

	private MeshRenderer meshRenderer;

	private Mesh mesh;

	private Actor actor;

	private Color currentColor;

	private Color targetColor;

	private float colorTimer;

	private float colorDuration;

	private static int _PaletteTex;

	private static int _Color;

	private static int _LineColor;

	private static int gDirLights;

	private static int gPtLights;

	private static int gPtLightInvRadii;

	private static Vector4[] gDirLightsVals;

	private static Vector4[] gPtLightsVals;

	private static float[] gPtLightInvRadiiVals;

	private static int gFloorShadowFadeDist;

	private static int gFloorShadowYPos;

	private static int gShadowCutoff;

	private static int gNormalMirrorFlipParams;

	private static int gScreenEffectVals;

	private static int gPaletteFXColor1Pct;

	private static int gPaletteFXColor2Alpha;

	private static Vector4 gPaletteFxColor1PctVal;

	private static Vector4 gPaletteFXColor2AlphaVal;

	private static int gBeamStretchParams;

	private static List<PointLightInfo> filteredPointLights;

	private const int kInitialVertexAlloc = 9240;

	private static Vector3[] meshVertices;

	private static int[] meshTriangles;

	private static Vector2[] meshUVs;

	private static Vector2[] meshUV2s;

	private static Color32[] meshColors;

	private static int lastVertexCount;

	private Vector3 centerPointOffset;

	private Vector3 lowerRight;

	private Vector3 lowerLeft;

	private Vector3 upperRight;

	private Vector3 upperLeft;

	public static int actorLayerMask
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public static void InitPool()
	{
	}

	public static ActorMesh TakeFromPool(Transform parent)
	{
		return null;
	}

	public static void ReturnToPool(ActorMesh actorMesh)
	{
	}

	public void Init(Actor myActor, Material material, Texture texture)
	{
	}

	public void End()
	{
	}

	public void GenerateMeshData(VertexInfo[] vertexList, int vertexListOffset, int vertexCount, Vector2 centerPoint)
	{
	}

	public void GenerateMeshData(VertexInfo[] vertexList, int vertexListOffset, int vertexCount, List<KeyValuePair<int, Vector2>> centerPoints)
	{
	}

	public void UpdateMeshAndUploadToGpu(float alpha = 1f)
	{
	}

	public void ClearMeshAndUploadToGpu()
	{
	}

	public void RefreshLightingParams()
	{
	}

	public void RefreshShadowParams()
	{
	}

	public void RefreshPaletteEffectParams(float percentage, Vector3 colorLo, Vector3 colorHi)
	{
	}

	public void RefreshBeamStretchParams(Vector4 beamParams)
	{
	}

	public void SetPaletteTexture(Texture2D paletteTexture)
	{
	}

	public void SetPaletteExtraFeatures(Palette palette, int paletteIndex, int playerIndex, int inTeamIndex, Actor actor)
	{
	}

	public void SetTargetColorTint(Color color, float duration = 0.5f)
	{
	}

	public void SetLineColorTint(Color color)
	{
	}

	public Color GetCurrentColor()
	{
		return default(Color);
	}

	public Color GetTargetColorTint()
	{
		return default(Color);
	}

	public float GetTargetColorTimer()
	{
		return 0f;
	}

	public void SetActive(bool active)
	{
	}

	public void SetRenderQueue(int renderQueue)
	{
	}

	public Bounds GetBounds()
	{
		return default(Bounds);
	}

	private static ActorMesh CreateNewActorMesh()
	{
		return null;
	}

	private static void AllocateVertexArrays(int vertexCount)
	{
	}
}
