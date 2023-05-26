using UnityEngine;

public class CharacterAbilityValentine : CharacterAbility
{
	[SerializeField]
	private float lifeStealPercentage;

	[SerializeField]
	private float redLifeMultiplier;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	protected override void OnActorLandedHit(object passed)
	{
	}

	protected override void OnMatchStarted(object passed)
	{
	}
}
