using UnityEngine;

public class SuperShadow : MonoBehaviour
{
	public const int kNumSuperShadows = 1;

	public const int kSuperShadowSpacing = 28;

	[SerializeField]
	private ActorTransform actorTransform;

	private static int superShadowFrameCounter;

	private static Material superShadowMaterial;

	private Actor myActor;

	private ActorMesh mainMesh;

	private ActorMesh mainMaskMesh;

	private VertexInfo[] vertexList;

	private float alpha;

	private AniFrame frame;

	private int blockOffsetInTexture;

	private int maskBlockOffsetInTexture;

	public static void ResetSuperShadowFrameCounter()
	{
	}

	public static bool IncrementSuperShadowFrameCounter()
	{
		return false;
	}

	public void Init(Actor actor, Texture2D superflashTexture)
	{
	}

	public void End()
	{
	}

	public bool HasEnded()
	{
		return false;
	}

	public void Step()
	{
	}

	public void Render()
	{
	}

	public void SetRenderQueue(int renderQueue)
	{
	}

	public void SetMaskRenderQueue(int maskRenderQueue)
	{
	}
}
