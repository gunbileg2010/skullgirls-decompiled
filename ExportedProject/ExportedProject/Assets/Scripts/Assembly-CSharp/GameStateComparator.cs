using System.IO;
using System.Text;

public static class GameStateComparator
{
	private static StringBuilder positionReport;

	public static bool CompareGameStates(BinaryReader readerA, BinaryReader readerB)
	{
		return false;
	}

	private static bool CompareFightData(BinaryReader readerA, BinaryReader readerB)
	{
		return false;
	}

	private static bool CompareFightStatsData(BinaryReader readerA, BinaryReader readerB)
	{
		return false;
	}

	private static bool CompareTeamData(BinaryReader readerA, BinaryReader readerB)
	{
		return false;
	}

	private static bool CompareSGRandomizerData(BinaryReader readerA, BinaryReader readerB, string identifier)
	{
		return false;
	}

	private static bool CompareActorData(BinaryReader readerA, BinaryReader readerB, out uint instanceId)
	{
		instanceId = default(uint);
		return false;
	}

	private static bool CompareActorDataPart2(BinaryReader readerA, BinaryReader readerB, uint instanceId)
	{
		return false;
	}

	private static bool CompareCameraData(BinaryReader readerA, BinaryReader readerB)
	{
		return false;
	}

	private static bool CompareSignatureAbilityData(SignatureAbility ability, BinaryReader readerA, BinaryReader readerB)
	{
		return false;
	}

	private static bool CompareSignatureAbilityConditionData(BinaryReader readerA, BinaryReader readerB)
	{
		return false;
	}

	private static bool ComparePrestigeAbilityData(PrestigeAbility ability, BinaryReader readerA, BinaryReader readerB)
	{
		return false;
	}

	private static bool CompareSlotValueHolderData(BinaryReader readerA, BinaryReader readerB)
	{
		return false;
	}

	private static bool CompareGearData(BinaryReader readerA, BinaryReader readerB)
	{
		return false;
	}

	public static void StartComparisonPositionLog()
	{
	}

	public static void RecordPositionLogEntry(Stream stream, Stream stream2, string label)
	{
	}

	public static void RecordPositionLogEntry(StringBuilder checksumReportOutput, Stream stream, Stream stream2, string label)
	{
	}

	public static void EndPositionLog()
	{
	}
}
