using System;
using System.IO;
using System.Net;

public class FileDownloader
{
	private enum State : byte
	{
		Idle = 0,
		PerformingRequest = 1,
		Error = 2,
		ErrorDiskFull = 3,
		ErrorMiscIO = 4
	}

	private const float kHangThresholdSeconds = 15f;

	private string remoteFileUrl;

	private string localFilePath;

	private long downloadOffsetBytes;

	private long bytesToReceive;

	private long bytesReceived;

	private DateTime lastTimeBytesReceived;

	private State state;

	private HttpWebRequest currentRequest;

	private int errorResponseCode;

	private HttpWebResponse downloadResponse;

	private FileStream outStream;

	private byte[] readBuffer;

	public FileDownloader(string remoteFileUrl, string localFilePath)
	{
	}

	public void GetHead()
	{
	}

	public void SetDownloadOffset(long offsetBytes)
	{
	}

	public void Download()
	{
	}

	public void Abort()
	{
	}

	public float GetProgress()
	{
		return 0f;
	}

	public bool IsComplete()
	{
		return false;
	}

	public bool IsPerformingRequest()
	{
		return false;
	}

	public bool HadError()
	{
		return false;
	}

	public long GetErrorResponseCode()
	{
		return 0L;
	}

	public bool GotDiskFullError()
	{
		return false;
	}

	public bool GotMiscIOError()
	{
		return false;
	}

	public bool IsHung()
	{
		return false;
	}

	public string GetRemoteFileUrl()
	{
		return null;
	}

	public string GetLocalFilePath()
	{
		return null;
	}

	private void OnHeadResponse(IAsyncResult result)
	{
	}

	private void OnDownloadResponse(IAsyncResult result)
	{
	}

	private void OnDownloadReadData(IAsyncResult result)
	{
	}

	private HttpWebResponse ParseResponseFromResult(IAsyncResult result)
	{
		return null;
	}

	private void HandleWebException(WebException webException)
	{
	}
}
