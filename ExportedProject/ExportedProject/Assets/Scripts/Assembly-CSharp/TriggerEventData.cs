public class TriggerEventData
{
	public static TriggerEventData FightFrameUpdated;

	public static TriggerEventData FightTimerTicked;

	public TriggerEvent triggerEvent;

	public Actor actor;

	public Modifier modifier;

	public SignatureAbility signatureAbility;

	public int strengthLevel;

	public TriggerEventData(TriggerEvent triggerEvent)
	{
	}

	public TriggerEventData(TriggerEvent triggerEvent, Actor provokingActor)
	{
	}

	public TriggerEventData GetCopy()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
