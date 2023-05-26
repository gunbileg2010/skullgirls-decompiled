using System.Collections.Generic;
using UnityEngine;

public class SignatureAbilityFeature : MonoBehaviour
{
	public string title;

	public string description;

	[SerializeField]
	private bool absoluteValue;

	[SerializeField]
	private string[] substitutions;

	public TriggerEvent triggerEvent;

	public List<TriggerEvent> additionalTriggerEvents;

	public SignatureAbilityTier.ActorFilter provokingActors;

	[SerializeField]
	private bool bypassAssignedGearCondition;

	public List<Condition> triggerConditions;

	public List<Condition> provokerConditions;

	public List<SignatureAbilityTier> tiers;

	public int level;

	private SignatureAbility signatureAbility;

	private object[] substitutionValues;

	private SGRandomizer randomizer;

	private void OnDestroy()
	{
	}

	public void Init(SignatureAbility signatureAbility)
	{
	}

	public bool IsUnlocked(int evolution)
	{
		return false;
	}

	public bool HasUpgrade(int startLevel, int upgradeLevel)
	{
		return false;
	}

	public void Apply(TriggerEventData provokingTriggerData)
	{
	}

	public string GetDescription(int evolution)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public void SetRandomGenerator(SGRandomizer rand)
	{
	}

	public SGRandomizer GetRandomizer()
	{
		return null;
	}

	public SignatureAbility GetSignatureAbility()
	{
		return null;
	}

	public int GetUnlockedLevel()
	{
		return 0;
	}

	private void OnEventTriggered(object passed)
	{
	}

	private SignatureAbilityTier GetTierForEvolution(int evolution)
	{
		return null;
	}

	private void RefreshSubstitutionValues(int evolution, bool absoluteValue = false)
	{
	}

	private bool ConvertSubstitutionToActualValue(string substitution, int evolution, ref object outVal)
	{
		return false;
	}
}
