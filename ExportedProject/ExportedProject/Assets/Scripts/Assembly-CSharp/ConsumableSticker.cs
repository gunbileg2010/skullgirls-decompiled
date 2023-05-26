using UnityEngine;
using UnityEngine.UI;

public class ConsumableSticker : MonoBehaviour
{
	[SerializeField]
	private GameObject activeGO;

	[SerializeField]
	private GameObject inactiveGO;

	[SerializeField]
	private GameObject glowGO;

	[SerializeField]
	private Button button;

	[SerializeField]
	private TimerUI consumableTimers;

	[SerializeField]
	private DynamicResourceHelper consumableImageDynamicResourceLoader;

	private bool showingActiveConsumable;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void UGUI_ConsumableStickerClicked()
	{
	}

	private void OnStateChanged(string oldState, string newState)
	{
	}

	private void UpdateConsumableSticker()
	{
	}
}
