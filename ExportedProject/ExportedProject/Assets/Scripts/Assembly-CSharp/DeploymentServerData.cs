using System.Collections.Generic;

public class DeploymentServerData
{
	public enum DeploymentDurationCategory
	{
		Short = 0,
		Medium = 1,
		Long = 2
	}

	public enum Status
	{
		NotStarted = 0,
		InProgress = 1,
		Completed = 2
	}

	private string deploymentGuid;

	private long xpReward;

	private List<Loot> bonusLoot;

	private List<DeploymentCharacterSlot> fighterSlots;

	private List<CharacterConstraintPair> bonusCharacterConstraints;

	private List<ElementConstraintPair> bonusElementConstraints;

	private List<TierConstraintPair> bonusTierConstraints;

	private int minPlayerLevelAvailableTo;

	private int maxPlayerLevelAvailableTo;

	private float averageFighterLevelBonusModifier;

	private string titleLocKey;

	private string flavorTextLocKey;

	private string deploymentInstanceBackendId;

	private List<string> assignedCharacterInstanceIds;

	private long? completionTimestamp;

	private DeploymentDurationCategory durationCategory;

	private long durationMinutes;

	private List<RewardServerData> rewards;

	private Status deploymentStatus;

	public DeploymentServerData()
	{
	}

	public DeploymentServerData(Dictionary<string, object> dataDict)
	{
	}

	public string GetDeploymentGuid()
	{
		return null;
	}

	public long GetXPReward()
	{
		return 0L;
	}

	public List<Loot> GetBonusLoot()
	{
		return null;
	}

	public List<CharacterConstraintPair> GetBonusCharacterConstraints()
	{
		return null;
	}

	public List<ElementConstraintPair> GetBonusElementConstraints()
	{
		return null;
	}

	public List<TierConstraintPair> GetBonusTierConstraints()
	{
		return null;
	}

	public List<DeploymentCharacterSlot> GetFighterSlots()
	{
		return null;
	}

	public string GetTitleLocKey()
	{
		return null;
	}

	public float GetAverageFighterLevelBonusModifier()
	{
		return 0f;
	}

	public string GetFlavorTextLocKey()
	{
		return null;
	}

	public string GetDeploymentInstanceBackendId()
	{
		return null;
	}

	public List<string> GetAssignedCharacterInstanceIds()
	{
		return null;
	}

	public long? GetCompletionTimestamp()
	{
		return null;
	}

	public DeploymentDurationCategory GetDurationCategory()
	{
		return default(DeploymentDurationCategory);
	}

	public long GetDurationMinutes()
	{
		return 0L;
	}

	public List<RewardServerData> GetRewards()
	{
		return null;
	}

	public void UpdateDeploymentStatus()
	{
	}

	public Status GetDeploymentStatus()
	{
		return default(Status);
	}
}
