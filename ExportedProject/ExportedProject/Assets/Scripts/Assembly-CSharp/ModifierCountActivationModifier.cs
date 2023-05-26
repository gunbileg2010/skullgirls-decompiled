using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ModifierCountActivationModifier : Modifier
{
	[Serializable]
	public class ModifierCountActivationEffect
	{
		public ModifierType type;

		public ModifierStrength strength;

		public bool allStrengths;

		public bool buff;

		public bool debuff;

		public int stacks;

		public bool greaterThanOrEqualTo;

		public Modifier modifier;
	}

	public enum Mode
	{
		SingleStack = 0,
		TotalCount = 1
	}

	[SerializeField]
	private Mode mode;

	[SerializeField]
	public List<ModifierCountActivationEffect> effects;

	[SerializeField]
	private bool checkEnemy;

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

	protected List<Modifier> GetModifiersToApply()
	{
		return null;
	}
}
