using System.IO;

public class HitInfo
{
	public enum HitAction : byte
	{
		DO_NOTHING = 0,
		DO_HIT = 1,
		DO_BLOCK = 2,
		DO_GRAB = 3,
		DO_REPORT_ONLY = 4
	}

	public const int DEFAULT_HIT_PAUSE = 7;

	public const ushort INVALID_PROJECTILE_TYPE = 65534;

	public const short HITSPARK_NONE = 0;

	public const short HITSPARK_BLOCK = -1;

	public const short HITSPARK_WHIFF = -2;

	public const short HITSPARK_LIGHT = 1;

	public const short HITSPARK_GUARD_CRUSH = 499;

	public ushort damage;

	public float meterGain;

	public ushort hitPause;

	public ushort hitStunLength;

	public byte hitTypeMask;

	public byte sparkType;

	public uint sparkSoundHash;

	public bool cannotKill;

	public bool cannotBeCountered;

	public HitAction actionOnAirHit;

	public HitAction actionOnAirBlock;

	public HitAction actionOnGroundHit;

	public HitAction actionOnGroundBlock;

	public SlotOpChain airSlotOps;

	public SlotOpChain groundSlotOps;

	public SlotOpChain blockSlotOps;

	public SlotOpChain toHitSlotOps;

	public bool toHitMeansUnblockable;

	public bool setVictimAsAttackerOnContact;

	public bool noWhiffSpark;

	public bool useExtentForHurtbox;

	public ushort createProjectileType;

	public SlotOpChain createProjectileSlotOps;

	public void ReadFromFile(BinaryReader reader)
	{
	}

	public void WriteToFile(BinaryWriter writer)
	{
	}

	public void Clear()
	{
	}
}
