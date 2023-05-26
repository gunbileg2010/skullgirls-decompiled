using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ConsumableManager : MonoBehaviour
{
	[SerializeField]
	private List<ConsumableData> consumables;

	[SerializeField]
	private MasterPopupData confirmConsumePopupData;

	[SerializeField]
	private MasterPopupData noConsumablesPopupData;

	[SerializeField]
	private MasterPopupData alreadyActiveConsumablePopupData;

	[SerializeField]
	private MasterPopupData consumableActivatedPopup;

	[SerializeField]
	private MasterPopupData consumablePickerPopupData;

	private bool isInInventoryOrConsumablePicker;

	private string kXPBoostGenericTitleKey;

	public event Action ConsumablesConsumed
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Start()
	{
	}

	public void SetIsInInventoryOrConsumablePicker(bool isInInventoryOrConsumablePicker)
	{
	}

	public List<ConsumableData> GetConsumables()
	{
		return null;
	}

	public List<ConsumableData> GetConsumablesOfType(ConsumableType consumableType)
	{
		return null;
	}

	public ConsumableData GetConsumableByGuid(string guid)
	{
		return null;
	}

	public void ConsumeConsumable(string guid, int amountToConsume, ConsumableRewardIcon icon, Action invalidConsumeContextCallback)
	{
	}

	public void ShowPickConsumableToConsumePopup(ConsumableType consumableType)
	{
	}

	public List<Loot> CreateConsumableLoots()
	{
		return null;
	}

	public List<Loot> CreateConsumableLoots(ConsumableType consumableType)
	{
		return null;
	}

	public void ShowConsumableTooltip(Transform contextualPopupSpawnPos)
	{
	}

	public bool IsInInventoryOrConsumablePicker()
	{
		return false;
	}

	public long GetXPConsumableAmountToReachMaxLevel(long currentXP, float xpPerConsumable, long currentAmountToConsume, long xpFromOtherSources, int levelCap, bool isShiny, RarityTier rarityTier)
	{
		return 0L;
	}

	public void PointAtXPConsumable(int consumableIndex, List<TutorialIndication> indications)
	{
	}

	public void DisableButtonsOnXPBoostPickerPopup(bool close, List<int> consumableIndexes)
	{
	}

	private void UpdateInventoryAndRefreshIcon(ConsumableData consumableData, ConsumableRewardIcon icon, int inventoryCount, int amountToConsume, bool logMetrics = true)
	{
	}

	private void ShowNoConsumablesOwnedPopup(string title)
	{
	}

	private Loot CreateConsumableLoot(ConsumableData data)
	{
		return null;
	}

	private void SetXPBoostTutorialIndicatorsActive(bool active)
	{
	}
}
