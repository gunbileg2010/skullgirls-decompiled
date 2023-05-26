public class DownloadFile
{
	private string remoteFileUrl;

	private string localFilePath;

	private long expectedFileSize;

	private string expectedMD5Hash;

	private bool fileNeedsDownload;

	private bool fileNeedsDecompress;

	private bool fileNeedsCopy;

	private long fileDownloadOffset;

	private FileDownloader fileDownloader;

	private string localDownloadFilePath;

	private FileDecompressor fileDecompressor;

	private string localDecompressFilePath;

	private FileCopier fileCopier;

	public DownloadFile(string remoteFileUrl, string localFilePath, bool needsToBeDecompressed)
	{
	}

	public void Sync(long expectedFileSize = 0L, string expectedMD5Hash = null)
	{
	}

	public bool IsDownloadNeeded()
	{
		return false;
	}

	public bool IsDecompressNeeded()
	{
		return false;
	}

	public bool IsCopyNeeded()
	{
		return false;
	}

	public void Download()
	{
	}

	public void AbortDownload()
	{
	}

	public bool IsDownloading()
	{
		return false;
	}

	public long GetDownloadSizeBytes()
	{
		return 0L;
	}

	public float GetDownloadProgress()
	{
		return 0f;
	}

	public bool IsDownloadComplete()
	{
		return false;
	}

	public bool DoesDownloadNeedRestart()
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

	public void Decompress()
	{
	}

	public bool IsDecompressing()
	{
		return false;
	}

	public float GetDecompressProgress()
	{
		return 0f;
	}

	public bool IsDecompressComplete()
	{
		return false;
	}

	public bool GotDecompressionError()
	{
		return false;
	}

	public void Copy()
	{
	}

	public bool IsCopying()
	{
		return false;
	}

	public bool IsCopyComplete()
	{
		return false;
	}

	public void FinalizeCopy()
	{
	}

	public void Cleanup()
	{
	}

	public void ResetForRetry()
	{
	}

	public string GetLocalFilePath()
	{
		return null;
	}

	private string GetLocalFileMD5Hash()
	{
		return null;
	}

	private void SaveLocalFileMD5Hash(string hash)
	{
	}

	private string GetDownloadFileMD5Hash()
	{
		return null;
	}

	private void SaveDownloadFileMD5Hash(string hash)
	{
	}
}
