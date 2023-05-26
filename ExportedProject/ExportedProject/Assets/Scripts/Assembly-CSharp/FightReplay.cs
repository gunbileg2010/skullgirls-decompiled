using System.Collections.Generic;
using System.IO;

public class FightReplay
{
	public class Header
	{
		public const int kHeaderDataSizeBytes = 30;

		public uint version;

		public int randomSeed;

		public const int kReplayDataOffsetPos = 12;

		public long replayDataOffset;

		public const int kReplayFrameLengthPos = 20;

		public uint replayLengthFrames;

		public bool containsChecksums;

		public bool containsP2Inputs;

		public byte aiDifficulty;

		public byte gameType;

		public bool isCompetitivePvP;

		public byte playerNumber;

		public bool IsValid()
		{
			return false;
		}
	}

	private string filepath;

	private FileStream fileStream;

	private BinaryReaderWrapper reader;

	private Header header;

	private Fight fight;

	private ZInput lastInputP1;

	private ZInput lastInputP2;

	private ushort nextFrameWithNewInputs;

	public FightReplay(string replayFileName)
	{
	}

	public void CleanUp()
	{
	}

	public string GetFilepath()
	{
		return null;
	}

	public bool IsValid()
	{
		return false;
	}

	public int GetRandomSeed()
	{
		return 0;
	}

	public int GetDifficulty()
	{
		return 0;
	}

	public bool IsCompetitiveVersusFight()
	{
		return false;
	}

	public bool IsVersusFight()
	{
		return false;
	}

	public bool IsTwoPlayerFight()
	{
		return false;
	}

	public bool ContainsChecksums()
	{
		return false;
	}

	public long GetSeekPosition()
	{
		return 0L;
	}

	public int GetReplayLengthInFrames()
	{
		return 0;
	}

	public int GetPlayerNumber()
	{
		return 0;
	}

	public Fight ReadInFight()
	{
		return null;
	}

	public bool ReachedEndOfReplay(int frameNumber)
	{
		return false;
	}

	public void ReadFrame(int frameNumber, out ZInput p1Input, out ZInput p2Input, out long checksum)
	{
		p1Input = null;
		p2Input = null;
		checksum = default(long);
	}

	private List<Character> DeserializeTeam(IDataReader dataReader)
	{
		return null;
	}

	private List<DynamicResource> DeserializeFightModifiers(IDataReader dataReader)
	{
		return null;
	}

	private List<CollectibleNodeModifier> DeserializeCollectibleNodeModifiers(IDataReader dataReader)
	{
		return null;
	}

	private Stage DeserializeStage(IDataReader dataReader)
	{
		return null;
	}
}
