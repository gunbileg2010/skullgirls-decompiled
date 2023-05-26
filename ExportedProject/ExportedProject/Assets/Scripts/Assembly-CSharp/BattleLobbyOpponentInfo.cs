using UnityEngine;

public class BattleLobbyOpponentInfo : MonoBehaviour
{
	[SerializeField]
	private PlayerSummary opponentSummary;

	[SerializeField]
	private LocalizedUGUIText opponentRating;

	[SerializeField]
	private GameObject victoryStatusParent;

	[SerializeField]
	private LocalizedUGUIText victoryStatusString;

	[SerializeField]
	private GameObject autoCompleteBattleGO;

	public void Populate(BattleInstanceServerData battleInstance)
	{
	}
}
