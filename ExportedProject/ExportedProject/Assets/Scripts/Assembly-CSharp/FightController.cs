using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

public class FightController : MonoSingleton<FightController>
{
	[SerializeField]
	private Fixed3 p1Start;

	[SerializeField]
	private Fixed3 p2Start;

	[SerializeField]
	private float startingSpecialMoveCooldownSeconds;

	[SerializeField]
	private int koFreezeFrameCount;

	[SerializeField]
	private int koSlowdownFrameCount;

	[SerializeField]
	private int koSlowdownSkipEveryXthFrame;

	public static bool runGGPOSyncTest;

	private static readonly uint MATCH_START_SHOWTIME_SPARK_HASH;

	private static readonly uint CHARACTER_DEATH_SPARK_HASH;

	private static readonly uint VICTORY_P1_SPARK_HASH;

	private static readonly uint VICTORY_BIG_SPARK_HASH;

	private static readonly uint VICTORY_PERFECT_SPARK_HASH;

	private static readonly uint VICTORY_CLOSE_CALL_SPARK_HASH;

	private static readonly uint VICTORY_TIMEOUT_SPARK_HASH;

	private static readonly uint ARCADE_LOSE_SPARK_HASH;

	private static readonly uint LOSE_TIMEOUT_SPARK_HASH;

	private static readonly uint DRAW_SPARK_HASH;

	private static readonly uint DISCONNECTED_SPARK_HASH;

	private const int kFadeInFrames = 50;

	private const int kRequestP1IntroPoseFrame = 1;

	private const int kRequestP2IntroPoseFrame = 30;

	private const int kPerformingIntrosMaxFrames = 600;

	private const int kShowtimeAnimFrames = 90;

	private const int kAwaitingWinPoseMaxFrames = 480;

	private const int kPerformingWinPoseMaxFrames = 360;

	private Fight fight;

	private FightState fightState;

	private WinState winState;

	private GameType gameType;

	private PlayerController leftSidePlayerController;

	private PlayerController rightSidePlayerController;

	private AutoplayController autoplayController;

	private static bool autoplayEnabled;

	private AIController aiController;

	private Controller p1TeamController;

	private Controller p2TeamController;

	private Team p1Team;

	private Team p2Team;

	private FightStats p1FightStats;

	private FightStats p2FightStats;

	private ScriptedSequence fightTutorial;

	private bool walkingEnabled;

	private FightWaitState waitState;

	private bool isFightInterrupted;

	private bool isInSuperflash;

	private int simulatedFrameCounter;

	private int stateFrameCounter;

	private int totalGameTimeFrames;

	private int gameTimeFrameCounter;

	private int lastInProgressFrameNumer;

	private Coroutine fightOutroCoroutine;

	private int paletteRenderFrame;

	private List<Palette.PaletteShiftState> paletteShiftStates;

	private FightRecorder fightRecorder;

	private ZInput p1RecordInput;

	private ZInput p2RecordInput;

	private FightReplay fightReplay;

	private ZInput p1ReplayInput;

	private ZInput p2ReplayInput;

	private long fightReplayChecksum;

	private const int kSaveStateIdentifier = 8675309;

	private const int kSaveStateBufferSize = 204800;

	private static byte[] saveState;

	private static int latestSaveStateFrame;

	private static int latestChecksum;

	private static int latestSaveStateSize;

	private static int latestPseudoSaveFrame;

	private static int latestPseudoChecksum;

	private const int kPseudoSavestateBufferSize = 2500;

	private static byte[] pseudoSaveState;

	private const int kFramesBetweenPingMeasurements = 60;

	private List<int> pingMeasurements;

	private ZButton localNetworkInput;

	private ZButton remoteNetworkInput;

	private const int kPlayerInputSize = 1;

	public const int kLocalGGPOInputSize = 1;

	private byte[] localInput;

	private byte[] ggpoInputs;

	private List<Palette> palettesUpdatedThisFrame;

	private int averagePing => 0;

	public static SGRandomizer GetFightRandomizer()
	{
		return null;
	}

	public static SGRandomizer GetSoundRandomizer()
	{
		return null;
	}

	public static SGRandomizer GetAIRandomizer()
	{
		return null;
	}

	public void InitFight(Fight fight, Action callback)
	{
	}

	public void StartFight()
	{
	}

	public void FadeOutAndEndMatch(bool restart, bool conceded = false)
	{
	}

	public void SetFightInterrupted(bool interrupted)
	{
	}

	public bool IsFightInterrupted()
	{
		return false;
	}

	public bool IsInSuperflash()
	{
		return false;
	}

	public void CallTagIn(int playerNumber, int teamPos)
	{
	}

	public bool CanDoTagIn(int playerNumber)
	{
		return false;
	}

	public bool CanTagInActor(int playerNumber, int teamPos)
	{
		return false;
	}

	public float GetTagInTimer(Actor actor)
	{
		return 0f;
	}

	public void StartTagInCooldown(int playerNumber)
	{
	}

	public void ResetTagInCooldown(int playerNumber)
	{
	}

	public void QueueGear(int playerNumber, int index)
	{
	}

	public void QueuePrestige(int playerNumber)
	{
	}

	public void HandleCharacterAbilityInput(int playerNumber, int index, bool keyDown = true)
	{
	}

	public void SetWalkingEnabled(bool enabled)
	{
	}

	public Team GetPlayerTeam()
	{
		return null;
	}

	public Team GetEnemyTeam()
	{
		return null;
	}

	public Team GetTeam(TeamType teamType)
	{
		return null;
	}

	public Team GetOtherTeam(TeamType teamType)
	{
		return null;
	}

	public Team GetTeam(int playerNumber)
	{
		return null;
	}

	public Team GetOtherTeam(int playerNumber)
	{
		return null;
	}

	public bool IsFTUEFight()
	{
		return false;
	}

	public void StopTutorial()
	{
	}

	public void SetFightWaitState(FightWaitState state)
	{
	}

	public void RestoreAutoplay()
	{
	}

	public void SetAutoplay(bool on, bool saveValue = true)
	{
	}

	public bool IsUsingAutoplay()
	{
		return false;
	}

	public bool IsReplay()
	{
		return false;
	}

	public bool IsSyncFight()
	{
		return false;
	}

	public bool ShouldUsePvpRules()
	{
		return false;
	}

	public bool IsTwoPlayerFight()
	{
		return false;
	}

	public Controller GetController(TeamType teamType)
	{
		return null;
	}

	public Controller GetController(int playerNumber)
	{
		return null;
	}

	public Controller GetEnemyController()
	{
		return null;
	}

	public Controller GetPlayerController()
	{
		return null;
	}

	public Fight GetFight()
	{
		return null;
	}

	public FightState GetFightState()
	{
		return default(FightState);
	}

	public bool HasFightStarted()
	{
		return false;
	}

	public WinState GetWinState()
	{
		return default(WinState);
	}

	public void SetMaxCombo(int count, int playerNumber)
	{
	}

	public FightStats GetPlayerFightStats()
	{
		return null;
	}

	public FightStats GetEnemyFightStats()
	{
		return null;
	}

	public float GetSecondsRemaining()
	{
		return 0f;
	}

	public float GetSecondsElapsed()
	{
		return 0f;
	}

	public bool IsInfiniteFight()
	{
		return false;
	}

	public bool IsCompetitiveSyncPvPEvent()
	{
		return false;
	}

	public int GetGameTimeFrameNumber()
	{
		return 0;
	}

	public int GetSimulatedFrameNumber()
	{
		return 0;
	}

	public bool IsLocalPlayerP1()
	{
		return false;
	}

	public int GetLocalPlayerNumber()
	{
		return 0;
	}

	public void UpdateCharacterTint()
	{
	}

	public bool IsSlowdownFrame()
	{
		return false;
	}

	public bool IsInRollback()
	{
		return false;
	}

	public bool IsSkippingInReplay()
	{
		return false;
	}

	public int GetChecksum()
	{
		return 0;
	}

	public int GetPseudoChecksum()
	{
		return 0;
	}

	public byte[] SaveGameStateWithCache(ref int size, ref int checksum)
	{
		return null;
	}

	public void SaveGameState(byte[] buffer, ref int size, ref int checksum)
	{
	}

	public void LoadGameState(byte[] buffer)
	{
	}

	public void LoadGameState(BinaryReader reader)
	{
	}

	public void SetFightSpeed(float speed)
	{
	}

	public float GetFightSpeed()
	{
		return 0f;
	}

	public void CleanUp(bool restart)
	{
	}

	public int GetAIDifficulty()
	{
		return 0;
	}

	public void Restart()
	{
	}

	public void ReplaceCharacter(int playerNumber, int index, Character character)
	{
	}

	private void InitializeAllActorsInFight(Action callback)
	{
	}

	private void FinishInitializeAllActorsInFight(Action callback)
	{
	}

	private void SetUpTeam(int playerNumber, Action<Team> callback)
	{
	}

	private void FinishSettingUpTeam(Team teamToSetup, TeamType teamType)
	{
	}

	private void SetFightState(FightState newFightState)
	{
	}

	private void UpdateGGPO()
	{
	}

	private void SimulateFrame()
	{
	}

	private void SimulateOneFightFrame()
	{
	}

	private void UpdateFightState()
	{
	}

	private void FightUpdatePreActorUpdate()
	{
	}

	private void FightUpdatePostActorUpdate()
	{
	}

	private void StartFightOutro()
	{
	}

	private IEnumerator PlayFightOutro(uint sfxHash, string headerText, string footerText, bool playerWon)
	{
		return null;
	}

	private IEnumerator DoFadeOutAndEndMatch(bool restart, bool conceded = false)
	{
		return null;
	}

	private void SwitchPointChar(int playerNumber, int changeTo)
	{
	}

	private void FightRecorderCleanUp()
	{
	}

	private void ClearAnyInput()
	{
	}

	private void OnOpponentDisconnected()
	{
	}

	private void OnGGPOAdvanceFrameDuringRollback()
	{
	}

	private void OnGGPOEvent(GGPO.GGPOEvent eventInfo)
	{
	}

	private void UpdatePaletteShiftStatuses()
	{
	}

	private void ResetCAButtonsForTeam(Team team)
	{
	}

	private void RecordSyncPvpFightStats()
	{
	}

	private void WriteTeamIntoEmailBody(StringBuilder bodyStringBuilder, Team team)
	{
	}

	public FightController()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
