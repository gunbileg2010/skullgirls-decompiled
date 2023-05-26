using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MatchChallenge : MonoBehaviour, IServerUploadable
{
	[SerializeField]
	private string description;

	[SerializeField]
	private bool absoluteValue;

	[SerializeField]
	private string[] substitutions;

	public TriggerEvent triggerEvent;

	public List<TriggerEvent> additionalTriggerEvents;

	public SignatureAbilityTier.ActorFilter provokingActors;

	public List<Condition> triggerConditions;

	public List<Condition> provokerConditions;

	public short target;

	public bool cannotMeetOrExceedTarget;

	private object[] substitutionValues;

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	public string GetDescription()
	{
		return null;
	}

	private void RefreshSubstitutionValues()
	{
	}

	private bool ConvertSubstitutionToActualValue(string substitution, ref object outVal)
	{
		return false;
	}
}
