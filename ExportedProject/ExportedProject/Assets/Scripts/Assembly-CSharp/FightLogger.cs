using System.IO;
using System.Text;
using UnityEngine;

public static class FightLogger
{
	public const string kLogFolderName = "Logs";

	public const string kLogFileExtension = "log";

	private static string filepath;

	private static FileStream fileStream;

	private static StreamWriter streamWriter;

	private static StringBuilder stringBuilder;

	private static int lastWrittenFrame;

	private static bool isActive;

	public static void SetupFightLog(string fileName = "MostRecent.sgm.rply")
	{
	}

	public static void CleanUp()
	{
	}

	public static void SaveState(BinaryWriter writer)
	{
	}

	public static void LoadState(BinaryReader reader)
	{
	}

	public static void LogSlotAction(Actor owner, int slotNum, float currentValue, float newValue)
	{
	}

	public static void LogFlagAction(Actor owner, int flagNum, bool currentValue, bool newValue)
	{
	}

	public static void LogPositionChangeAction(Actor actor, Vector3 positionChange)
	{
	}

	public static void LogAction(params object[] action)
	{
	}

	public static void WriteLog()
	{
	}

	private static bool ShouldLogSlot(Slot slot, float currentValue, float newValue)
	{
		return false;
	}

	private static bool ShouldLogFlag(int flag, bool currentValue, bool newValue)
	{
		return false;
	}
}
