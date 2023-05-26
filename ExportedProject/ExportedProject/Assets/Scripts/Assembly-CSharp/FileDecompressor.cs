public class FileDecompressor
{
	private enum State : byte
	{
		Idle = 0,
		Decompressing = 1,
		Done = 2,
		ErrorDiskFull = 3,
		ErrorMiscIO = 4,
		ErrorCorruptData = 5
	}

	private string inputFilePath;

	private string outputFilePath;

	private LZMAUtil.Progress decompressionProgress;

	private State state;

	public FileDecompressor(string compressedFilePath, string outputFilePath)
	{
	}

	public void Decompress()
	{
	}

	public float GetProgress()
	{
		return 0f;
	}

	public bool IsDecompressing()
	{
		return false;
	}

	public bool IsComplete()
	{
		return false;
	}

	public bool GotDiskFullError()
	{
		return false;
	}

	public bool GotMiscIOError()
	{
		return false;
	}

	public bool GotCorruptDataError()
	{
		return false;
	}

	private void DecompressionThread(object contextNull)
	{
	}
}
