using UnityEngine;

public class SkillTreeEmptyNodeUI : SkillTreeNodeUI
{
	[SerializeField]
	private CharacterPortrait portrait;

	public override void Populate(SkillTreeNode inNode, SkillTreeNodeStateData data, Character character = null)
	{
	}

	private void OnPortraitClicked(CharacterPortrait portrait)
	{
	}
}
