public enum InteractionType
{
	CAN_HIT_ALLIES = 1,
	CAN_BE_HIT_BY_ALLIES = 2,
	CANNOT_HIT_ENEMIES = 4,
	CANNOT_BE_HIT_BY_ENEMIES = 8,
	INTERACTIONS_REPORT_ONLY = 0x10,
	I_AM_UNTHROWABLE = 0x20,
	ALWAYS_COUNT_HITS_AS_SUPER_FINISH = 0x40,
	NOT_STOPPED_BY_PARENT_SUPERFLASH = 0x80,
	USE_ALLY_LEADER_PALETTE_EFFECTS = 0x100,
	STEAL_LEADERS_THROW_VICTIM = 0x200,
	USE_THROWERS_HITBOXES = 0x400,
	EXTERNAL_ASSIST_LOCK = 0x800,
	NOT_STOPPED_BY_ANY_SUPERFLASH = 0x1000,
	WANTS_MUTE_MUSIC = 0x2000,
	INHERIT_PARENT_HITPAUSE_WHEN_ATTACKING = 0x4000,
	WANT_CAMERA_CONTROL = 0x8000,
	COUNT_ASSIST_AS_USED_NOW = 0x10000
}
