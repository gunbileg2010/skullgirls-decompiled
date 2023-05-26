using System.Collections.Generic;

public class ModifierData
{
	public int frameTimer;

	public Modifier modifier;

	public HashSet<int> signatureAbilitiesThatAdjustedDuration;

	private Fixed duration;

	public Fixed GetDuration()
	{
		return default(Fixed);
	}

	public int GetDurationInFrames()
	{
		return 0;
	}

	public void SetDuration(Fixed duration)
	{
	}

	public TriggerEvent GetUnapplyTriggerEvent()
	{
		return default(TriggerEvent);
	}

	public bool ShouldUnapplyAllStacks()
	{
		return false;
	}

	public void AddToSignatureAbilitiesThatHaveAdjustedDuration(int saInstanceId)
	{
	}

	public bool HasSignatureAbilityAdjustedDuration(int saInstanceId)
	{
		return false;
	}
}
