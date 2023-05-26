using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillTreeGateNodeUI : SkillTreeNodeUI
{
	[Serializable]
	public class Gates
	{
		public GameObject overlay;

		public float lockOffset;
	}

	[SerializeField]
	private List<Gates> gates;

	[SerializeField]
	private Color darkColor;

	[SerializeField]
	private Color lightColor;

	[SerializeField]
	private float period;

	private Gates activeGate;

	private MaskableGraphic overlayGraphic;

	private float lerp;

	private Coroutine coroutine;

	public override void Populate(SkillTreeNode inNode, SkillTreeNodeStateData data, Character character = null)
	{
	}

	public override void SetSelected(bool isSelected)
	{
	}

	public override void Refresh()
	{
	}

	private IEnumerator Pulse(bool loop)
	{
		return null;
	}

	private void HideGraphics()
	{
	}
}
