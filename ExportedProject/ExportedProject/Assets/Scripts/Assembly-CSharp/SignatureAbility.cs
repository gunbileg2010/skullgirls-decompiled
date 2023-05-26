using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SignatureAbility : MonoBehaviour
{
	[SerializeField]
	private string title;

	public List<SignatureAbilityFeature> features;

	public const int kDefaultFeatureCount = 2;

	private Actor assignedActor;

	private Gear assignedGear;

	private static int instanceIdCounter;

	private int instanceId;

	private bool ignoreAccuracyAndResistance;

	public void Init(Actor actor, int level)
	{
	}

	public void Init(Actor actor, int[] levels)
	{
	}

	public void Init(Actor actor)
	{
	}

	public void SetupRandomizer()
	{
	}

	public static void ResetInstanceIdCounter()
	{
	}

	public int GetSAInstanceId()
	{
		return 0;
	}

	public string GetDescription(int evolution, Color digitsColor)
	{
		return null;
	}

	public string GetDescription(int[] levels, Color digitsColor, int startingFeatureIndex = 0)
	{
		return null;
	}

	public string GetTitle()
	{
		return null;
	}

	public string GetTitleForFeatureSet(int featureSetIndex)
	{
		return null;
	}

	public string GetDescriptionForFeatureSet(int featureSetIndex, int level, Color digitsColor)
	{
		return null;
	}

	public bool HasUnlockedFeature(int evolution)
	{
		return false;
	}

	public void SetAssignedGear(Gear gear)
	{
	}

	public Gear GetAssignedGear()
	{
		return null;
	}

	public void SetAssignedActor(Actor actor)
	{
	}

	public Actor GetAssignedActor()
	{
		return null;
	}

	public bool HasUpgrade(int startLevel, int upgradeLevel)
	{
		return false;
	}

	public int GetUnlockLevel()
	{
		return 0;
	}

	public int GetMaxLevelForFeatureSet(int featureSetIndex)
	{
		return 0;
	}

	public bool ShouldIgnoreAccuracyAndResistance()
	{
		return false;
	}

	public void SetShouldIgnoreAccuracyAndResistance(bool shouldIgnore)
	{
	}

	public void SaveState(BinaryWriter writer)
	{
	}

	public void LoadState(BinaryReader reader)
	{
	}

	private string GetFormattedFeatureDescription(int featureIndex, int evolution, Color digitsColor)
	{
		return null;
	}
}
