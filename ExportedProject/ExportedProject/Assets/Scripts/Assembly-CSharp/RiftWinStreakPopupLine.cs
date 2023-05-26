using UnityEngine;

public class RiftWinStreakPopupLine : MonoBehaviour
{
	[SerializeField]
	private LocalizedUGUIText streakLabel;

	[SerializeField]
	private LocalizedUGUIText hpAmount;

	[SerializeField]
	private UIGradient32 hpGradient;

	[SerializeField]
	private LocalizedUGUIText atkAmount;

	[SerializeField]
	private UIGradient32 atkGradient;

	[SerializeField]
	private LocalizedUGUIText riftCoinAmount;

	[SerializeField]
	private UIGradient32 riftCoinGradient;

	public void Populate(int streakIndex, GameSettings.WinStreakModifierRiftBattles winStreakModifierRiftBattles, float riftCoinMultiplier)
	{
	}
}
