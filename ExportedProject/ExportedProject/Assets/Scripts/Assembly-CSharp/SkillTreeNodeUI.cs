using System;
using UnityEngine;
using UnityEngine.UI;

public class SkillTreeNodeUI : MonoBehaviour
{
	[SerializeField]
	protected Image icon;

	[SerializeField]
	protected Image frame;

	[SerializeField]
	protected Image glow;

	[SerializeField]
	protected Transform focus;

	protected Animator animator;

	protected SkillTreeNode node;

	protected SkillTreeNodeStateData stateData;

	protected Action<SkillTreeNodeUI> pressCallback;

	protected bool selected;

	protected DynamicResource iconResourceRef;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public virtual void Populate(SkillTreeNode inNode, SkillTreeNodeStateData data, Character character = null)
	{
	}

	public Vector3 GetFocusPosition()
	{
		return default(Vector3);
	}

	public SkillTreeNodeStateData GetStateData()
	{
		return null;
	}

	public SkillTreeNode GetNode()
	{
		return null;
	}

	public virtual void Refresh()
	{
	}

	public void SetPressCallback(Action<SkillTreeNodeUI> callback)
	{
	}

	public Action<SkillTreeNodeUI> GetPressCallback()
	{
		return null;
	}

	public void UGUI_ButtonPressed()
	{
	}

	public Sprite GetIconSprite()
	{
		return null;
	}

	public virtual void SetAvailable(bool isAvailable)
	{
	}

	public virtual void SetSelected(bool isSelected)
	{
	}

	protected void SetNodeImage(Image image, Sprite sprite)
	{
	}
}
