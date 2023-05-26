using UnityEngine;
using UnityEngine.UI;

public class ChallengesPopup : SGUGUIPopup
{
	[SerializeField]
	private ChallengesView challenges;

	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	public override void Show()
	{
	}

	public override void Hide()
	{
	}
}
