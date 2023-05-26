using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PurchaseStatusServerData
{
	public enum VerifyResult
	{
		Unknown = 0,
		VerificationSucceeded = 1,
		VerificationFailed = 2,
		AlreadyClaimed = 3,
		GrantRewardsFailed = 4
	}

	public const string kStatus = "status";

	public const string kRewards = "rewards";

	public const string kBonusRewards = "bonusRewards";

	public VerifyResult status
	{
		[CompilerGenerated]
		get
		{
			return default(VerifyResult);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public List<Reward> rewards
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public PurchaseStatusServerData(Dictionary<string, object> data)
	{
	}
}
