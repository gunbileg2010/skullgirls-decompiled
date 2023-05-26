using UnityEngine;
using UnityEngine.EventSystems;

public class GearCardSlot : CardSlot, IPointerClickHandler, IEventSystemHandler
{
	[SerializeField]
	private GameObject lockGO;

	[SerializeField]
	private GameObject selectedState;

	[SerializeField]
	private Transform _anchor;

	private bool isUnlocked;

	private GearEquipController gearEquipController;

	public Transform Anchor
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public void SetUnlocked(bool unlocked)
	{
	}

	public bool IsUnlocked()
	{
		return false;
	}

	public void BringToFront(bool value)
	{
	}

	public void SetSelected(bool value)
	{
	}

	public void SetGearEquipController(GearEquipController gearEquipController)
	{
	}

	public GearEquipController GetGearEquipController()
	{
		return null;
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	protected override void OnDropInternal(PointerEventData eventData)
	{
	}
}
