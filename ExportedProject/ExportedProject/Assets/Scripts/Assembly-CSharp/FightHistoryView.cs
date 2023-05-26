using UnityEngine;

public class FightHistoryView : MonoBehaviour
{
	[SerializeField]
	private LeaderboardEventTeamView defendingTeamView;

	[SerializeField]
	private LeaderboardEventTeamView enemyTeamView;

	[SerializeField]
	private LocalizedUGUIText resultText;

	[SerializeField]
	private LocalizedUGUIText timestampText;

	[SerializeField]
	private Gradient winColor;

	[SerializeField]
	private Gradient loseColor;

	[SerializeField]
	private PopupData playerOptionsPopupData;

	private XsProfile enemyProfile;

	public void Populate(FightHistoryServerData fightHistory, bool shouldShowPoints = true, bool flipWinLoss = false, bool flipTeams = false)
	{
	}

	public void PopulateFromReplay(FightReplayServerData fightReplayData)
	{
	}

	private void EnemyTeamViewPressed(LeaderboardEventTeamView pressedTeamView)
	{
	}
}
