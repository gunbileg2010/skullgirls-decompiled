using UnityEngine;

public class EventRewardItemView : MonoBehaviour
{
	[SerializeField]
	private GameObject flagGO;

	[SerializeField]
	private LocalizedUGUIText milestoneText;

	[SerializeField]
	private GameObject claimableGO;

	[SerializeField]
	private GameObject claimedGO;

	[SerializeField]
	private GameObject progressGO;

	[SerializeField]
	private RectTransform progressBarFill;

	[SerializeField]
	private LocalizedUGUIText progressHeaderText;

	[SerializeField]
	private LocalizedUGUIText progressText;

	[SerializeField]
	private BattleRankBadge rankBadge;

	[SerializeField]
	private LocalizedUGUIText headerText;

	[SerializeField]
	private RewardScrollView rewardsScrollView;

	public void Populate(EventReward eventReward, EventReward contextualEventReward, long score = 0L, int tier = 1)
	{
	}

	public void Clear()
	{
	}

	public void SetRiftBattleRankBadge(RiftTier labTier, bool visible = true)
	{
	}

	public void ShowHideRewardsScrollViewArea(bool isOn)
	{
	}

	public void SetRewardText(string text)
	{
	}

	public void SetRewardTextSubstitution(string subKey, string text)
	{
	}

	private void PopulateImmediateReward(long rewardTarget, long previousRewardTarget, long currentScore, int tier)
	{
	}

	private void PopulateNonImmediateReward(EventReward reward, EventReward contextualReward)
	{
	}
}
