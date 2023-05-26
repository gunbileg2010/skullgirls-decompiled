using System;
using System.Collections.Generic;
using UnityEngine;

public class SignatureAbilityTier : MonoBehaviour
{
	[Serializable]
	public class ActorFilter
	{
		public bool provokingActor;

		public bool assignedActor;

		public bool assignedActorTeammates;

		public bool enemyActor;

		public bool enemyActorTeammates;

		private List<Actor> actors;

		public List<Actor> GetValidActors(Actor saActor, Actor provoker = null)
		{
			return null;
		}
	}

	[Serializable]
	public class ModifierSet
	{
		public string name;

		public ActorFilter actorFilter;

		public List<Modifier> modifiers;
	}

	[Serializable]
	public class StringSubstitution
	{
		public string id;

		public string value;

		public StringSubstitution CreateDeepCopy()
		{
			return null;
		}
	}

	public List<Condition> triggerConditions;

	public List<Condition> provokerConditions;

	public List<ModifierSet> modifierSets;

	public List<StringSubstitution> additionalStringSubstitutions;

	public int unlockAtLevel;

	private SignatureAbilityFeature feature;

	public void Init(SignatureAbilityFeature feature)
	{
	}

	public void Apply(TriggerEventData assignedActorTriggerData, TriggerEventData provokingActorTriggerData)
	{
	}

	public void SetRandomGenerator(Randomizer rand)
	{
	}
}
