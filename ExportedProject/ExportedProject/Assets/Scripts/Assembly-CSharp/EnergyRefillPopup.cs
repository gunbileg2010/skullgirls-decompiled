using System;
using System.Collections.Generic;
using UnityEngine;

public class EnergyRefillPopup : MasterPopup
{
	public class EnergyRefillPopupContextData
	{
		public List<Character> lowEnergyFighters;

		public CurrencyType paymentType;

		public Action refilledCallback;

		public Action cancelCallback;

		public Action failedCallback;
	}

	[SerializeField]
	public AdvancedButton negativeButton;

	[SerializeField]
	public AdvancedButton positiveButton;

	[SerializeField]
	public LocalizedUGUIText energyHeaderText;

	[SerializeField]
	public LocalizedUGUIText energyBodyText;

	private EnergyRefillPopupContextData data;

	private int prevNavConfig;

	private int cachedEnergyRefillsCost;

	private int cachedHardCurrencyCost;

	public override void Show()
	{
	}

	public void UGUI_ConfirmButtonPressed()
	{
	}

	public void UGUI_CancelButtonPressed()
	{
	}

	private void DoRefillWithEnergyRefill()
	{
	}

	private void DoRefillWithHardCurrency()
	{
	}

	private void UpdateRefillCostForCurrencyType(CurrencyType type)
	{
	}

	private void DoEnergyRefillRequest()
	{
	}
}
