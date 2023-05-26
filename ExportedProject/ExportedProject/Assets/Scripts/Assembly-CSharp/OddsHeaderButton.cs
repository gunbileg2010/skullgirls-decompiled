using UnityEngine;
using UnityEngine.UI;

public class OddsHeaderButton : MonoBehaviour
{
	public Toggle toggleButton;

	[SerializeField]
	private Image gachaImage;

	private DynamicResource gachaSprite;

	private RelicOddsPopup parent;

	private GachaData gachaData;

	private int index;

	private void Awake()
	{
	}

	public void FetchIcon()
	{
	}

	public void ReturnIcon()
	{
	}

	public void ValueChanged(bool value)
	{
	}

	public void SetData(RelicOddsPopup parent, int index, GachaData gachaData)
	{
	}
}
