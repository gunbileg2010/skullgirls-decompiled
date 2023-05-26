using UnityEngine;
using UnityEngine.UI;

public class SkillTreeBBNodeUI : SkillTreeNodeUI
{
	[SerializeField]
	protected Text bbText;

	public override void Populate(SkillTreeNode inNode, SkillTreeNodeStateData data, Character character = null)
	{
	}
}
