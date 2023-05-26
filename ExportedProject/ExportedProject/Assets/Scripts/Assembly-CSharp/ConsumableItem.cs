using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ConsumableItem : MonoBehaviour
{
	[SerializeField]
	private GameObject effectAmountGO;

	[SerializeField]
	private GameObject amountToConsumeGO;

	[SerializeField]
	private Image frame;

	[SerializeField]
	private Image amountToConsumeFrame;

	[SerializeField]
	private Image decrementButtonBG;

	[SerializeField]
	private LocalizedUGUIText amountToConsumeText;

	[SerializeField]
	private LocalizedUGUIText effectAmountText;

	[SerializeField]
	private ConsumableRewardIcon consumableDisplay;

	[SerializeField]
	private float minSpeed;

	[SerializeField]
	private float maxSpeed;

	[SerializeField]
	private float maxHoldTime;

	private int inventoryCount;

	private long maxAmountToConsume;

	private float amountToConsume;

	private float effectAmount;

	private float currentTotalEffectAmount;

	private float previousTotalEffectAmount;

	private const float kDelayBeforeAutoIncrementOrDecrement = 0.125f;

	private bool showingUsageCountUI;

	private bool doAutoIncrementOrDecrement;

	private Func<bool> canIncreaseUsageCallback;

	private string consumableGuid;

	private EZAnimateFloat speedUpAnimation;

	private Coroutine doAutoIncrementOrDecrementCoroutine;

	public event Action<ConsumableItem> AmountToConsumeIncreased
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

	public event Action<ConsumableItem> AmountToConsumeDecreased
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

	public event Action<ConsumableItem> AutoIncrementOrDecrementBegan
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

	private void OnDisable()
	{
	}

	public void Populate(ConsumableData consumableData, Func<bool> canIncreaseUsageCallback)
	{
	}

	public void StopAutomaticIncrementOrDecrementSequence()
	{
	}

	public void UGUI_ConsumableItemPressed(bool increment)
	{
	}

	public void UGUI_ConsumableItemReleased()
	{
	}

	public void TryConsume()
	{
	}

	public void RefreshMaxAmountToConsume(long maxAmountToConsume)
	{
	}

	public bool IsBeingUsed()
	{
		return false;
	}

	public string GetConsumableGuid()
	{
		return null;
	}

	public int GetAmountToConsume()
	{
		return 0;
	}

	public float GetCurrentTotalEffectAmount()
	{
		return 0f;
	}

	public float GetPreviousTotalEffectAmount()
	{
		return 0f;
	}

	public float GetEffectAmount()
	{
		return 0f;
	}

	private void ToggleUsageCountUI(bool show)
	{
	}

	private void RefreshAmountToConsumeUI()
	{
	}

	private bool DecrementAmountToConsume(float amountToDecreaseBy)
	{
		return false;
	}

	private bool IncrementAmountToConsume(float amountToIncreaseBy)
	{
		return false;
	}

	private IEnumerator DoAutoIncrementOrDecrementSequence(Func<float, bool> incrementOrDecrementCallback)
	{
		return null;
	}

	private void RefreshTotalEffectAmounts()
	{
	}
}
