using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GearGenerator
{
	public int autoSelectType;

	public GearData gearData;

	public Vector2 levelRange;

	public Vector2 strengthRange;

	public int gearTierMask;

	public bool IsAuthored()
	{
		return false;
	}

	public int GetTierMask()
	{
		return 0;
	}

	public Gear GenerateGear(VariantCharacterData variantData, int availableGearPoints, bool canChooseStrongGear, List<Gear> usedGears, bool useCollection = false, Dictionary<string, List<Gear>> gearCollection = null)
	{
		return null;
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	private GearData ChooseGearData(VariantCharacterData variantData, int availableGearPoints, bool canChooseStrongGear, List<Gear> usedGears)
	{
		return null;
	}

	private Gear GenerateGearFromCollection(Dictionary<string, List<Gear>> gearCollection)
	{
		return null;
	}

	private Gear GenerateNewGear(VariantCharacterData variantData, int availableGearPoints, bool canChooseStrongGear, List<Gear> usedGears)
	{
		return null;
	}
}
