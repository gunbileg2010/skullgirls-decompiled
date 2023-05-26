using UnityEngine;
using UnityEngine.UI;

public class FighterAlertBadge : MonoBehaviour
{
	[SerializeField]
	private Image alertErrorBackgroundImage;

	[SerializeField]
	private Image alertEnergyBackgroundImage;

	[SerializeField]
	private Image generalAlertImage;

	[SerializeField]
	private Image energyAlertImage;

	[SerializeField]
	private Image energyRefillImage;

	[SerializeField]
	private GameObject energyRefillGlowGO;

	[SerializeField]
	private GameObject energyRefillTouchButtonGO;

	public void ShowGeneralAlert()
	{
	}

	public void ShowEnergyAlert()
	{
	}

	public void ShowEnergyRefill()
	{
	}

	public bool HasGeneralAlert()
	{
		return false;
	}

	public bool HasEnergyAlert()
	{
		return false;
	}

	public bool HasEnergyRefillShown()
	{
		return false;
	}

	private void HideAll()
	{
	}
}
