using System;
using System.Collections.Generic;

public class RewardsPopupData : SGUGUIPopupData
{
	public string titleText;

	public ButtonInfo[] buttons;

	[NonSerialized]
	public int addVoucherButtonIndex;

	[NonSerialized]
	public int denominationIndex;

	[NonSerialized]
	public GachaData gachaData;

	[NonSerialized]
	public bool showPurchaseBonusLabel;

	private List<Reward> _rewards;

	private List<RewardServerData> _rewardServerData;

	public virtual List<Reward> rewards
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual List<RewardServerData> rewardServerData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}
}
