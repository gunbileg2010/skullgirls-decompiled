using System;
using UnityEngine;

public class Energy
{
	private EnergyType type;

	private int availableEnergy;

	private int maxEnergy;

	private DateTime nextEnergyDateTime;

	private float energyCooldownSeconds;

	public static EnergyType GetCurrentEnergyType()
	{
		return default(EnergyType);
	}

	public Energy(EnergyType type, int maxEnergy, float energyCooldownSeconds)
	{
	}

	public void UpdateFromServerEnergy(CharacterServerData.CharacterServerEnergy serverEnergy)
	{
	}

	public int GetAvailable()
	{
		return 0;
	}

	public int GetMax()
	{
		return 0;
	}

	public bool AtMaxEnergy()
	{
		return false;
	}

	public void Use(int amount)
	{
	}

	public void Refill()
	{
	}

	public float GetSecondsToNextEnergy()
	{
		return 0f;
	}

	public float GetFractionToNextEnergy()
	{
		return 0f;
	}

	public void SetEnergyCooldown(float newEnergyCooldownSeconds)
	{
	}

	public Sprite GetSprite()
	{
		return null;
	}

	public Gradient GetGradient()
	{
		return null;
	}

	private void SetAvailable(int newEnergy)
	{
	}

	private void UpdateEnergyFromTimestamp()
	{
	}
}
