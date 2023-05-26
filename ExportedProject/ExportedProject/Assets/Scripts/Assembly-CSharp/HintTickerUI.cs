using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HintTickerUI : MonoBehaviour
{
	[SerializeField]
	private LocalizedUGUIText titleText;

	[SerializeField]
	private LocalizedUGUIText bodyText;

	[SerializeField]
	private RawImage displayImage;

	[SerializeField]
	private float tickerDurationSeconds;

	[SerializeField]
	public TickerItem[] tickerItems;

	private Coroutine tickerCoroutine;

	private CanvasGroup tickerGOCanvasGroup;

	private Vector3 tickerGOPosition;

	private DynamicResource loadedImage;

	private int tickerIndex;

	private bool skipping;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	public void StartTicker()
	{
	}

	public void StopTicker()
	{
	}

	public void UGUI_SkipToNext()
	{
	}

	private IEnumerator DoRunTicker(int index = 0)
	{
		return null;
	}

	private void IncrementTickerItem()
	{
	}

	private IEnumerator DoStopTicker()
	{
		return null;
	}

	private IEnumerator DoShowTickerTexts(TickerItem tickerItem)
	{
		return null;
	}

	private IEnumerator DoHideTickerTexts()
	{
		return null;
	}

	private void UnloadImage()
	{
	}
}
