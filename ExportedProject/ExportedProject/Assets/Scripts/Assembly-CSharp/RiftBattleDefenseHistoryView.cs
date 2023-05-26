using System;
using UnityEngine;

public class RiftBattleDefenseHistoryView : MonoBehaviour
{
	[SerializeField]
	private PlayerSummary defendingPlayer;

	[SerializeField]
	private PlayerSummary attackingPlayer;

	[SerializeField]
	private GameObject badgeGO;

	[SerializeField]
	private LocalizedUGUIText resultText;

	[SerializeField]
	private LocalizedUGUIText playerRiftRatingText;

	[SerializeField]
	private LocalizedUGUIText opponentRiftRatingText;

	[SerializeField]
	private LocalizedUGUIText opponentScoreText;

	[SerializeField]
	private LocalizedUGUIText timestampText;

	[SerializeField]
	private Gradient winColor;

	[SerializeField]
	private Gradient loseColor;

	[SerializeField]
	private LocalizedUGUIText revengeText;

	[SerializeField]
	private AdvancedButton revengeButton;

	[SerializeField]
	private PopupData playerOptionsPopupData;

	private BattleInstanceServerData battleInstance;

	private BattleLobbyScreen battleLobbyScreen;

	public void Populate(BattleInstanceServerData battleInstance, BattleLobbyScreen battleLobbyScreen)
	{
	}

	public void UGUI_Revenge()
	{
	}

	public void UGUI_ViewDetailedHistory()
	{
	}

	public void UGUI_RiftOpponentClicked()
	{
	}

	private string GetTimeAgoString(TimeSpan timespan)
	{
		return null;
	}
}
