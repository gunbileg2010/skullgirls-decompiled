using System.Threading;
using UnityEngine;

public class Decompressor
{
	private class DecompressionJob
	{
		public CompressedImage image;

		public byte[] artMemory;

		public int artMemoryOffset;

		public int channel;

		public unrle src;

		public unatlas copySrc;

		public unatlas dst;

		public ManualResetEvent doneEvent;
	}

	public const int kBPP = 4;

	public const TextureFormat kAtlasTextureFormat = TextureFormat.RGBA32;

	private const int MAX_WORK_ITEMS = 50;

	private DecompressionJob[] workItems;

	private int currentWorkItem;

	private ManualResetEvent[] workItemDoneEvents;

	private WaitCallback decompressionWaitCallback;

	private Texture2D atlasTexture;

	private Texture2D superShadowsTexture;

	private int frameNumber;

	private byte[][] decompressedData;

	private int previousDataIndex;

	private int currentDataIndex;

	private int numAdded;

	private int atlasWidthBlocks;

	private int blocksUsed;

	public Decompressor(int atlasWidthPixels, int atlasHeightPixels)
	{
	}

	public void Destroy()
	{
	}

	public void AddImageForDecompression(CompressedImage image, ref byte[] artMemory, int artMemoryOffset)
	{
	}

	public void AddImageForCopy(CompressedImage image, int srcFirstBlockIndex, int destFirstBlockIndex)
	{
	}

	public void WaitForProcessingToFinish()
	{
	}

	public void SwapAtlases()
	{
	}

	public int GetUsedBlocksCount()
	{
		return 0;
	}

	public int GetAvailableBlocksCount()
	{
		return 0;
	}

	public int GetTotalBlocksCount()
	{
		return 0;
	}

	public int GetCurrentFrameNumber()
	{
		return 0;
	}

	public Texture2D GetAtlas()
	{
		return null;
	}

	public Texture2D UpdateSuperShadowAtlas()
	{
		return null;
	}

	public void CreateSuperShadowTexture()
	{
	}

	public void DestroySuperShadowTexture()
	{
	}

	private int GetPixelHeightUsed()
	{
		return 0;
	}

	private void CopyFromPreviousFrame(CompressedImage image, int numBlocks, int srcFirstBlockIndex, int srcWidthBlocks, int destFirstBlockIndex, int destWidthBlocks, unatlas copySrc, unatlas copyDest)
	{
	}

	private void DecompressOrCopyThread(object data)
	{
	}
}
