using System.Collections.Generic;

public class GearLoadout
{
	private string backendId;

	private BaseCharacterData baseCharacter;

	private List<Gear> gearList;

	public GearLoadout()
	{
	}

	public GearLoadout(GearLoadoutServerData data)
	{
	}

	public List<Gear> GetGears()
	{
		return null;
	}

	public void SetGear(List<Gear> inGear)
	{
	}

	public void RemoveGear(Gear gear)
	{
	}

	public void UpdateFromGearLoadoutServerData(GearLoadoutServerData loadoutData)
	{
	}

	public string GetBackendId()
	{
		return null;
	}

	public BaseCharacterData GetBaseCharacter()
	{
		return null;
	}

	public void SetBaseCharacter(BaseCharacterData baseCharacterData)
	{
	}

	public bool IsDuplicateOf(GearLoadout other)
	{
		return false;
	}

	public bool HasSameGear(List<Gear> otherGearList)
	{
		return false;
	}

	public string GetGearGuidsForMetrics()
	{
		return null;
	}

	public bool HasAnyGearsEquipped()
	{
		return false;
	}
}
