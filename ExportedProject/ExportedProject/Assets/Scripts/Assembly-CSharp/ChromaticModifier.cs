using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ChromaticModifier : Modifier
{
	[Serializable]
	public class ChromaticEffect
	{
		public Element element;

		public Modifier modifier;
	}

	[SerializeField]
	private List<ChromaticEffect> effects;

	[SerializeField]
	private bool useEnemyElement;

	[SerializeField]
	private bool useTeammateElements;

	public override string GetDisplayName()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public override List<Modifier> GetInternalModifiers()
	{
		return null;
	}

	public override void LoadState(BinaryReader reader)
	{
	}

	protected override void Apply()
	{
	}

	private void ActivateEffectForElement(Element element)
	{
	}
}
