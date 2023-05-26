using UnityEngine;

public class SetScreenTutorialModeSequentialAction : SequentialAction
{
	private enum TutorialScreen
	{
		CharacterDetails = 0,
		TopBar = 1,
		TeamSelect = 2,
		MatchPreview = 3,
		SkillTree = 4
	}

	[SerializeField]
	private bool active;

	[SerializeField]
	private TutorialScreen screen;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}
}
