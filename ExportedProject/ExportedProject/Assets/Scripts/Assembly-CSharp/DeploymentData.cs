using System.Collections.Generic;
using UnityEngine;

public class DeploymentData : GuidScriptableObject, IServerUploadable
{
	[SerializeField]
	private long xpReward;

	[SerializeField]
	private List<Loot> bonusLoot;

	[SerializeField]
	private List<DeploymentCharacterSlot> fighterSlots;

	[SerializeField]
	private int bonusConstraintRollNumber;

	[SerializeField]
	private ConstraintSet bonusConstraints;

	[SerializeField]
	private int minPlayerLevelAvailableTo;

	[SerializeField]
	private int maxPlayerLevelAvailableTo;

	[SerializeField]
	private float averageFighterLevelBonusModifier;

	[SerializeField]
	private string titleLocKey;

	[SerializeField]
	private string flavorTextLocKey;

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
