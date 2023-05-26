using UnityEngine;
using UnityEngine.UI;

public class ReplayPreviewPopup : SGUGUIPopup
{
	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private FightReplayView fightReplayView;

	private FightReplayServerData replayServerData;

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void UGUI_PlayReplayPressed()
	{
	}
}
