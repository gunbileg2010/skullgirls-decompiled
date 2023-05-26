using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class GearCardHolder : Card
{
	[SerializeField]
	private Text gearPointsCost;

	[SerializeField]
	private Transform gearCardAnchor;

	[SerializeField]
	private GameObject selectedState;

	[SerializeField]
	private GameObject equippedState;

	[SerializeField]
	private GameObject equippedTextGO;

	[SerializeField]
	private GameObject sellCheckmark;

	private readonly Color kEquippedTintColor;

	private Gear gear;

	private GearCard gearCard;

	private GearCardSlot slot;

	private Character character;

	public event Action<GearCardHolder> Selected
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

	public void Populate(Character character, Gear gear)
	{
	}

	public override void Clear()
	{
	}

	public Gear GetGear()
	{
		return null;
	}

	public GearCard GetGearCard()
	{
		return null;
	}

	public void SetSlot(GearCardSlot slot)
	{
	}

	public GearCardSlot GetSlot()
	{
		return null;
	}

	public void SetEquipped(Character character, bool equipped)
	{
	}

	public void ShowGlow(bool value)
	{
	}

	public void SetToSell(bool value)
	{
	}

	public bool GetToSell()
	{
		return false;
	}

	public void SetPalette(Character character)
	{
	}

	public void RefreshGearCard()
	{
	}

	public void UGUI_Select(bool wasLongPressed)
	{
	}
}
