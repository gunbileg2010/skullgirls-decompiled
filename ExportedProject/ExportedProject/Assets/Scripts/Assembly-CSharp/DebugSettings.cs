using UnityEngine;

public class DebugSettings : ScriptableObject
{
	public static bool isEditorTestFight;

	public GameObject debugCanvas;

	public bool debugEnemyAI;

	public bool disableEnemyAI;

	public bool enableP2Inputs;

	public bool debugPlayerAI;

	public bool disablePlayerAI;

	public bool startWithAutoplay;

	public bool markInputsAsUsed;

	public bool drawStageGrid;

	public bool showFps;

	public string overrideIP;

	public float offlineBackendCommsDelay;

	public BuildSettings.DefaultBackend editorBackendOverride;

	public string fightReplayFileName;

	public bool replayChecksums;

	public int skipToReplayFrame;

	public bool forcePvpRules;

	public bool allowPrivateConnect;

	public bool allowPublicConnect;

	public bool allowRelayConnect;

	public bool startFightAsSyncTest;

	public bool deepChecksumFightController;

	public bool deepChecksumPointActors;

	public bool deepChecksumAllActors;

	public bool deepChecksumSlotsInActors;

	public bool sendEndOfFightDesyncReplayMailsInEditor;

	public bool disableGearRestrictions;

	public bool enableGearAbilities;

	public bool enableSignatureAbility;

	[SerializeField]
	public int signatureAbilityLevel;

	public bool enableSuperAbility1;

	public bool enableSuperAbility2;

	public bool enableCharacterAbility;

	public bool enablePrestigeAbility;

	[SerializeField]
	public int prestigeAbilityLevel;

	public bool enableAdvancedCombo;

	public bool enableAdvancedJuggle;

	public bool enableChargeUpgrade;

	public bool disableAutowalk;

	public bool showFighterDebug;

	public bool displayInputBuffer;

	public bool displayFrameData;

	public bool startEditorFightAsLocalPvp;

	public bool allFightersShowShinyVisuals;

	public bool displaySlotDebug;

	public bool disableMusic;

	public bool enableVideoCaptureMode;

	public bool runInBackground;

	public bool allowOfferPopupsToAutoTrigger;

	public bool forceOfferPopupsToAutoTrigger;

	public bool enableKioskMode;

	public void LoadDebugPreferences()
	{
	}

	public bool ShouldEnableHttpDebugOutput()
	{
		return false;
	}

	public bool HasValidEditorFightReplay()
	{
		return false;
	}

	public string GetEditorFightReplayPath()
	{
		return null;
	}
}
