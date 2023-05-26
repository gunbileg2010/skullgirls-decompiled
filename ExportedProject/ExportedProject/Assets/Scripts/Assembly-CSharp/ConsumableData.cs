using System.Collections.Generic;
using UnityEngine;

public class ConsumableData : GuidScriptableObject, IServerUploadable
{
	[SerializeField]
	private ConsumableType consumableType;

	[SerializeField]
	private int duration;

	[SerializeField]
	private float effectAmount;

	[SerializeField]
	private DynamicResource consumableSprite;

	[SerializeField]
	private RarityTier rarityTier;

	[SerializeField]
	private string effectDescription;

	[SerializeField]
	private string title;

	[SerializeField]
	private string description;

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	public string GetTitle()
	{
		return null;
	}

	public string GetDescription()
	{
		return null;
	}

	public float GetEffectAmount()
	{
		return 0f;
	}

	public string GetEffectAmountText()
	{
		return null;
	}

	public ConsumableType GetConsumableType()
	{
		return default(ConsumableType);
	}

	public RarityTier GetRarityTier()
	{
		return default(RarityTier);
	}

	public DynamicResource GetDynamicSpriteResource()
	{
		return null;
	}

	public Sprite TakeConsumableSprite()
	{
		return null;
	}

	public bool ShouldAlwaysShowEffectAmount()
	{
		return false;
	}

	public void ReturnConsumableSprite()
	{
	}
}
