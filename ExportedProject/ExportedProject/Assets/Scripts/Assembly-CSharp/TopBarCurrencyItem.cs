using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class TopBarCurrencyItem : MonoBehaviour
{
	[SerializeField]
	private Image currencyIcon;

	[SerializeField]
	private UIGradient32 textGradient;

	[SerializeField]
	private TallyText tallyUpText;

	[SerializeField]
	private Text rawText;

	[SerializeField]
	private ButtonSound buttonSound;

	[SerializeField]
	private CurrencyType debugCurrenctyType;

	[SerializeField]
	private Element debugElement;

	[SerializeField]
	private RarityTier debugRarity;

	[SerializeField]
	private BaseCharacterData debugCharacterData;

	private Action<CurrencyType> cachedCallback;

	public CurrencyType currentCurrencyType
	{
		[CompilerGenerated]
		get
		{
			return default(CurrencyType);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Element? currentElement
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public RarityTier? currentRarity
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public BaseCharacterData currentCharacterData
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private void OnEnable()
	{
	}

	private void DebugPopulate()
	{
	}

	public void SetType(CurrencyType currencyType, Element? element, RarityTier? rarity, BaseCharacterData characterData)
	{
	}

	public void SetValue(bool immediate, int? overrideValue = null)
	{
	}

	public void SetValue(string overrideText)
	{
	}

	public bool Matches(CurrencyType currencyType)
	{
		return false;
	}

	public bool Matches(CurrencyType currencyType, Element? elementToCompare, RarityTier? rarityToCompare, BaseCharacterData characterDataToCompare)
	{
		return false;
	}

	public void SetCallbackAction(Action<CurrencyType> callback)
	{
	}

	public void Refresh()
	{
	}

	public void UGUI_ButtonPressed()
	{
	}

	private void SetValue(bool immediate, int? overrideValue, string overrideText)
	{
	}
}
