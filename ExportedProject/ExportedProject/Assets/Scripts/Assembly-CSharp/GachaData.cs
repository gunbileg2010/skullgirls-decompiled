using System;
using System.Collections.Generic;
using UnityEngine;

public class GachaData : GuidScriptableObject, IServerUploadable
{
	public enum Type
	{
		Standard = 0,
		EarnOverTime = 1
	}

	[Serializable]
	public class WeightedLootTableSet
	{
		public LootTableSet lootTableSet;

		public int weight;
	}

	[Serializable]
	public class Denomination
	{
		public int amount;

		public List<Loot> bonusLoot;
	}

	public Type type;

	public string title;

	public string description;

	public string tooltipDescription;

	[SerializeField]
	private DynamicResource gachaSprite;

	[SerializeField]
	private Color gachaColor;

	[SerializeField]
	private DynamicResource gachaPrefab;

	[SerializeField]
	private bool mirrorOnMainMenu;

	[SerializeField]
	private int relicOddsPanelIndex;

	public Price price;

	public RarityTier priceTierContext;

	[SerializeField]
	private bool displayAboveAllElse;

	[SerializeField]
	private int displayPriority;

	public Transform teaseStickerPrefab;

	public float teaseStickerScale;

	[SerializeField]
	private WeightedLootTableSet[] lootTableSets;

	public List<Loot> topLoot;

	public Denomination[] denominations;

	public float timeToEarnSeconds;

	public Loot descriptionLoot;

	public bool bypassCollectionCapCheck;

	[NonSerialized]
	private GameObject gacha3D;

	public List<Loot> GetLoot()
	{
		return null;
	}

	public Sprite TakeGachaSprite()
	{
		return null;
	}

	public Color TakeGachaColor()
	{
		return default(Color);
	}

	public void ReturnGachaSprite()
	{
	}

	public GameObject GetGacha3DInstance()
	{
		return null;
	}

	public void CleanupGacha3DInstance()
	{
	}

	public bool DisplayAboveAllElse()
	{
		return false;
	}

	public int GetDisplayPriority()
	{
		return 0;
	}

	public float GetMainMenuXScale()
	{
		return 0f;
	}

	public string GetGachaSpritePath()
	{
		return null;
	}

	public DynamicResource.LoadType GetGachaLoadType()
	{
		return default(DynamicResource.LoadType);
	}

	public string GetBundleName()
	{
		return null;
	}

	public bool HasTeaseSticker()
	{
		return false;
	}

	public Transform GetTeaseStickerPrefab()
	{
		return null;
	}

	public float GetTeaseStickerScale()
	{
		return 0f;
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	public int GetRelicOddsPanelIndex()
	{
		return 0;
	}

	public string GetVoucherDenominationString(int index)
	{
		return null;
	}
}
