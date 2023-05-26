using UnityEngine;

public class FX32Image : MonoBehaviour
{
	private SpriteRenderer spriteRenderer;

	private uint currentHash;

	private Sprite[] currentFrames;

	private int currentRenderQueue;

	private void Awake()
	{
	}

	public void Set(uint fx32Hash, int frameNumber, int blendType, Fixed spriteAlpha, int tintIndex = 0)
	{
	}

	public void Hide()
	{
	}

	public void SetRenderQueue(int renderQueue)
	{
	}
}
