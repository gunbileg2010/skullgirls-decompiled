using System;
using System.Collections.Generic;
using System.IO;

public class FightRecorder
{
	public const string kReplayFileIdentifier = "RPLY";

	public const uint kClientReplayVersion = 5u;

	private readonly string filepath;

	private FileStream fileStream;

	private BinaryWriterWrapper writer;

	private FightReplay.Header replayHeader;

	private ZButton p1InputLastFrame;

	private ZButton p2InputLastFrame;

	public FightRecorder(bool writeChecksum)
	{
	}

	public FightRecorder(string fileName, bool writeChecksum)
	{
	}

	public void CleanUp()
	{
	}

	public void WriteHeaderAndStartState(Fight fight, int randomSeed, byte playerNumber, Action callback = null)
	{
	}

	public void WriteFrame(int frameNumber, ZInput p1Input, ZInput p2Input, long checksum, bool forceInputWrite = false)
	{
	}

	public void WriteFightLength(int finalFrameNumber)
	{
	}

	public void SaveState(BinaryWriter writer)
	{
	}

	public void LoadState(BinaryReader reader)
	{
	}

	public static void LoadStateDummy(BinaryReader reader)
	{
	}

	public bool ShouldWriteChecksums()
	{
		return false;
	}

	private void SetupStream()
	{
	}

	private void SerializeTeam(List<Character> team, IDataWriter writer)
	{
	}

	private void SerializeFightModifiers(List<DynamicResource> fightModifiers, IDataWriter writer)
	{
	}

	private void SerializeCollectibleNodeModifiers(List<CollectibleNodeModifier> collectibleNodeModifiers, IDataWriter writer)
	{
	}
}
