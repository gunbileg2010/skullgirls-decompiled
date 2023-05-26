using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ConversionModifier : Modifier
{
	[SerializeField]
	private ModifierType conversionType;

	[SerializeField]
	private bool debuff;

	[SerializeField]
	private bool buff;

	[SerializeField]
	private bool allStrengths;

	[SerializeField]
	private int numberToConvert;

	[SerializeField]
	private bool convertAll;

	[SerializeField]
	private bool overrideDuration;

	[SerializeField]
	private Modifier convertTo;

	public override List<Modifier> GetInternalModifiers()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public override string GetDisplayName()
	{
		return null;
	}

	public Modifier Convert(Modifier modifier)
	{
		return null;
	}

	public override void LoadState(BinaryReader reader)
	{
	}

	protected override void Apply()
	{
	}
}
