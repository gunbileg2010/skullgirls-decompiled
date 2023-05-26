using UnityEngine;
using UnityEngine.UI;

public class RiftBattleScoreInfoPopup : SGUGUIPopup
{
	[SerializeField]
	protected Image backgroundImage;

	[SerializeField]
	protected RectTransform frameTransform;

	[SerializeField]
	private LocalizedUGUIText victoryLabel;

	[SerializeField]
	private LocalizedUGUIText healthLabel;

	[SerializeField]
	private LocalizedUGUIText timeLabel;

	[SerializeField]
	private LocalizedUGUIText noDeathsLabel;

	[SerializeField]
	private LocalizedUGUIText bbFinishLabel;

	[SerializeField]
	private LocalizedUGUIText xComboLabel;

	[SerializeField]
	private LocalizedUGUIText noLostFightsLabel;

	[SerializeField]
	private LocalizedUGUIText attackerDiversityLabel;

	[SerializeField]
	private Color baseTextColor;

	private const int kMaxFighterCount = 3;

	private const int kMaxTime = 180;

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	private void PopulateLabel(LocalizedUGUIText text, params string[] subs)
	{
	}
}
