using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CompressedImage
{
	public const int BLOCK_WIDTH = 16;

	public const int BLOCK_HEIGHT = 16;

	public const int BLOCK_SIZE = 256;

	public const int ATLAS_W_PIXELS = 1024;

	public const int ATLAS_H_PIXELS = 1024;

	public const int ATLAS_W_BLOCKS = 64;

	public static readonly Fixed kInvBlockWidth;

	public const int NUM_RLE_CHANNELS = 3;

	public const int VERTS_PER_TILE = 4;

	private const int kLargestImageBlockSize = 5100;

	private static int[] tempAtlasBlockNums;

	private const int kPaletteIndexOffset = 0;

	private const int kShadingOffset = 1;

	private const int kNormalsOffset = 2;

	private static VertexInfo tempVert;

	private ushort widthInBlocks;

	private ushort heightInBlocks;

	private ushort numBlocksExtant;

	private bool hasHalfResShading;

	private int lastCopyToAtlasFrameNumber;

	private short lastCopyToAtlasBlockStart;

	private int renderMemBaseOffset;

	private int[] renderChannelMemSize;

	private List<byte> rleBlockExistsList;

	public void ReadFromFile(BinaryReader reader, out IntVector2 amountMoved)
	{
		amountMoved = default(IntVector2);
	}

	public void Clear()
	{
	}

	public bool QueueForDecompression(byte[] artMemory, int artMemoryOffset, Decompressor decompressor)
	{
		return false;
	}

	public bool CopyFromPreviousFrame(byte[] artMemory, int artMemoryOffset, Decompressor decompressor)
	{
		return false;
	}

	public unsafe void UnRLEToTexture(byte* dest, int destWidthInBlocks, ref byte[] artMemory, int artMemoryOffset, bool decompressNormals, int onlyDoThisChannel = -1, unrle src = null, unatlas dst = null)
	{
	}

	public int PopulateVertexList(ref VertexInfo[] vertexList, int vertexListOffset = 0, int firstAtlasBlockIndexOverride = -1)
	{
		return 0;
	}

	public void GetBeamStretchParams(int beamStretchPixels, ref Vector4 beamStretchParams, Fixed2 centerPoint, int beamStretchCustomStartPixel)
	{
	}

	public ushort GetWidthInBlocks()
	{
		return 0;
	}

	public ushort GetHeightInBlocks()
	{
		return 0;
	}

	public bool DoesBlockExist(int blockNum)
	{
		return false;
	}

	public ushort GetTotalNumBlocks()
	{
		return 0;
	}

	public ushort GetNumBlocksExtant()
	{
		return 0;
	}

	public int GetRenderMemoryTotalSize()
	{
		return 0;
	}

	public int GetRenderMemoryBaseOffset()
	{
		return 0;
	}

	public void SetRenderMemoryBaseOffset(int newOffset)
	{
	}

	public int GetWidthPixels()
	{
		return 0;
	}

	public int GetHeightPixels()
	{
		return 0;
	}

	public int GetLastDecompressedFrameNumber()
	{
		return 0;
	}

	public int GetLastRenderBlockNumber()
	{
		return 0;
	}

	private bool CanBeRendered(byte[] artMemory, Decompressor decompressor)
	{
		return false;
	}
}
