using UnityEngine;

public class CheckLoginRewardsSequentialAction : SequentialAction
{
	[SerializeField]
	private PopupData rewardCalendarPopupData;

	private const int kSplashScreenPopupCooldownMinutes = 60;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}

	private void OnHideRewardCalendarPopup(IPopup popup)
	{
	}
}
