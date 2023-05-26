using UnityEngine;
using UnityEngine.UI;

public class MissionControlPopup : SGUGUIPopup
{
	public enum MissionControlView
	{
		Challenges = 0,
		Deployments = 1,
		Achievements = 2
	}

	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private ToggleGroupRowController sectionToggleController;

	[SerializeField]
	private Toggle challengesToggle;

	[SerializeField]
	private Toggle deploymentsToggle;

	[SerializeField]
	private Toggle accoladesToggle;

	[SerializeField]
	private ToggleLockUI deploymentsLock;

	[SerializeField]
	private ToggleLockUI achievementsLock;

	[SerializeField]
	private ChallengesView challenges;

	[SerializeField]
	private DeploymentsView deployments;

	[SerializeField]
	private AchievementsView achievements;

	[SerializeField]
	private ContextualTutorial deploymentsContextualTutorial;

	[SerializeField]
	private ContextualTutorial achievementsContextualTutorial;

	private MissionControlView activeView;

	protected override void Awake()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void UGUI_LockedDeploymentsPressed()
	{
	}

	public void UGUI_LockedAchievementsPressed()
	{
	}

	private void OnToggleActivated(Toggle toggle)
	{
	}
}
