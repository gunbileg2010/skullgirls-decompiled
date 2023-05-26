public enum FightState : byte
{
	FADING_IN = 0,
	PERFORMING_INTROS = 1,
	ROUND_ACTION_ANIM_PLAYING = 2,
	START_FRAME = 3,
	IN_PROGRESS = 4,
	KO_SLOWDOWN = 5,
	AWAITING_WINPOSE = 6,
	PERFORMING_WINPOSE = 7,
	WINPOSE_IDLE = 8,
	FADING_OUT = 9,
	FADED_OUT = 10
}
