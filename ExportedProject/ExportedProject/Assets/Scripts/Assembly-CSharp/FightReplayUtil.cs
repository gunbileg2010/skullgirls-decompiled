using System.Collections.Generic;

public static class FightReplayUtil
{
	public const string kReplayFolderName = "Replays";

	public const string kReplayFileExtension = "sgm.rply";

	public const string kDefaultReplayFileName = "MostRecent.sgm.rply";

	static FightReplayUtil()
	{
	}

	public static List<string> GetAllReplayPaths()
	{
		return null;
	}

	public static string GetMostRecentReplayFileName()
	{
		return null;
	}

	public static string GetReplayPath(string replayFileName)
	{
		return null;
	}

	public static string GetLogPathForReplay(string replayFileName)
	{
		return null;
	}

	public static string GetTimestampedFileName()
	{
		return null;
	}

	public static void MailReplay(string replayFileName = null, string toEmailAddress = "andrew@hiddenvariable.com", bool skipLogs = false, string subjectOverride = null, string bodyOverride = null)
	{
	}

	public static bool RenameReplay(string currentFileName, string newFileName)
	{
		return false;
	}

	public static void DeleteReplay(string replayFileName)
	{
	}

	public static string GetMostRecentReplayAsCompressedBase64String()
	{
		return null;
	}

	public static void DownloadAndPlayReplay(string replayId)
	{
	}

	private static void CompressReplay(string inFile, string outFile)
	{
	}

	private static void DecompressReplay(byte[] data, string outFile)
	{
	}

	private static bool RenameLog(string currentReplayName, string newReplayName)
	{
		return false;
	}

	private static void DeleteLogForReplay(string replayFileName)
	{
	}

	private static bool MoveFile(string currentFilePath, string newFilePath)
	{
		return false;
	}

	private static void DeleteFile(string filePath)
	{
	}
}
