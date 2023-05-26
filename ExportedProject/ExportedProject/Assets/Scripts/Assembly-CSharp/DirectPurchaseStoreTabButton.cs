using UnityEngine;
using UnityEngine.UI;

public class DirectPurchaseStoreTabButton : MonoBehaviour
{
	[SerializeField]
	private Toggle toggle;

	[SerializeField]
	private LocalizedUGUIText text;

	[SerializeField]
	private Image image;

	private string mappingToOpen;

	private DirectPurchaseStorePopup parent;

	public void Populate(DirectPurchaseStorePopup parent, string locKey, Sprite icon, string mappingToOpen)
	{
	}

	public void UGUI_ValueChanged(bool value)
	{
	}

	public Toggle GetToggle()
	{
		return null;
	}
}
