using System.Collections.Generic;

public struct GameStateData
{
	public byte fightState;

	public byte winState;

	public bool walkingEnabled;

	public byte waitState;

	public bool isFightInterrupted;

	public bool isInSuperflash;

	public int simulatedFrameCounter;

	public int stateFrameCounter;

	public int totalGameTimeFrames;

	public int gameTimeFrameCounter;

	public int slowdownFrameNumber;

	public int playerTeamTagInFrameTimer;

	public int playerTeamTagInMaxFrames;

	public int enemyTeamTagInFrameTimer;

	public int enemyTeamTagInMaxFrames;

	public FightStatsStateData p1FightStats;

	public FightStatsStateData p2FightStats;

	public int paletteRenderFrame;

	public int paletteShiftStateCount;

	public List<PaletteShiftStateData> paletteShiftStates;

	public RandomizerStateData fightRandomizer;

	public RandomizerStateData aiRandomizer;

	public Fixed[] slotValueStaticData;

	public TeamStateData p1TeamData;

	public TeamStateData p2TeamData;

	public int nextSuperflashIndex;

	public int actorCount;

	public List<Actor> actors;

	public CameraStateData cameraStateData;

	public List<SignatureAbilityStateData> signatureAbilityStateDatas;

	public RandomizerStateData soundRandomizer;

	public bool hasLeftSideController;

	public PlayerControllerStateData leftControllerStateData;

	public bool hasRightSideController;

	public PlayerControllerStateData rightControllerStateData;

	public bool hasAutoplayController;

	public AutoplayControllerStateData autoplayControllerStateData;

	public bool autoplayEnabled;

	public bool hasAiController;

	public AiControllerStateData aiControllerStateData;

	public byte playerControllerType;

	public byte enemyControllerType;

	public bool hasFightRecorder;

	public long fightRecorderStreamPosition;

	public uint fightRecorderReplayLengthFrames;

	public long fightLogStreamPosition;

	public string fightLogStringBuilder;

	public int fightLogLastWrittenFrame;
}
