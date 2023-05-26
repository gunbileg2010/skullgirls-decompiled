using SevenZip;
using SevenZip.Compression.LZMA;

public static class LZMAUtil
{
	public class Progress : ICodeProgress
	{
		public float progress;

		public void SetProgress(long inSize, long outSize)
		{
		}
	}

	private static Decoder decoder;

	public static void CompressFile(string inFile, string outFile)
	{
	}

	public static void DecompressFile(string inFile, string outFile, Progress decompressProgress = null)
	{
	}

	public static void Cleanup()
	{
	}
}
