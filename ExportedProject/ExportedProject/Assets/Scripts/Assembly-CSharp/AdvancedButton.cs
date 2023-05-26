using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdvancedButton : MonoBehaviour
{
	[SerializeField]
	private Text text;

	[SerializeField]
	private ButtonType buttonType;

	[SerializeField]
	private Gradient customGradient;

	[SerializeField]
	private UIGradientMapped gradientMap;

	[SerializeField]
	private Image glow;

	public float glowStrength;

	[SerializeField]
	private TimerUI buttonTimer;

	[SerializeField]
	private GameObject currencyGO;

	private Button _button;

	private List<CurrencyDisplayUI> currencyDisplays;

	private LocalizedUGUIText localizedText;

	private LayoutElement layoutElement;

	private IEnumerator dynamicCurrencyEnumerator;

	private Button button => null;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SetButtonType(ButtonType buttonType)
	{
	}

	public void SetInteractable(bool interactable)
	{
	}

	public bool IsInteractable()
	{
		return false;
	}

	public void SetWidth(float width)
	{
	}

	public void ResetWidth()
	{
	}

	public void SetHeight(float height)
	{
	}

	public void ResetHeight()
	{
	}

	public void SetLocalizedText(string text)
	{
	}

	public void SetText(string label)
	{
	}

	public void SetTimer(DateTime expirationDate, Action expirationCallback)
	{
	}

	public Text GetText()
	{
		return null;
	}

	public void SetClickCallback(Action callback)
	{
	}

	public void AddPrice(Price price)
	{
	}

	public void AddCurrency(Currency currency, CurrencyDisplayUI existingCurrencyDisplay = null)
	{
	}

	public void AddDynamicCurrency(Currency currency, Action<CurrencyDisplayUI> currencyUpdateAction)
	{
	}

	public void AddVoucherPrice(GachaData gacha, int amount, string denominationString)
	{
	}

	public void AddDisplayPrice(string displayPrice)
	{
	}

	public void ClearCurrencies()
	{
	}

	private void RefreshGradientAndGlow()
	{
	}

	private CurrencyDisplayUI GetNewCurrencyDisplayUI()
	{
		return null;
	}

	private IEnumerator DynamicCurrencyUpdate(CurrencyDisplayUI dynamicDisplay, Action<CurrencyDisplayUI> currencyUpdateAction)
	{
		return null;
	}
}
