using System.Collections.Generic;
using UnityEngine;

public class GearHudItems : MonoBehaviour
{
	[SerializeField]
	private GearHudItem gearPrefab;

	private List<GearHudItem> gearHudItems;

	private void Awake()
	{
	}

	public void Populate(Character character)
	{
	}

	public List<GearHudItem> GetGearHudItems()
	{
		return null;
	}

	private void DisableIcons()
	{
	}

	private void SetupGearHUD(Actor actor, Queue<GearHudItem> cachedUI, int idx)
	{
	}
}
