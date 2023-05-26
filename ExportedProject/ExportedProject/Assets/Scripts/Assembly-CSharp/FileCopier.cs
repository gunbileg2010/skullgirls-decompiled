public class FileCopier
{
	private enum State : byte
	{
		Idle = 0,
		Copying = 1,
		Done = 2,
		ErrorDiskFull = 3,
		ErrorMiscIO = 4
	}

	private string sourceFilePath;

	private string destFilePath;

	private State state;

	public FileCopier(string sourceFilePath, string destFilePath)
	{
	}

	public void Copy()
	{
	}

	public bool IsCopying()
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

	private void CopyThread(object contextNull)
	{
	}
}
