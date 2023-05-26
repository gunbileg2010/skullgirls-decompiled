using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ElementConstraintPair : ConstraintPair
{
	[SerializeField]
	private ElementConstraint elementConstraint;

	private List<Element> elements;

	public ElementConstraintPair()
	{
	}

	public ElementConstraintPair(Dictionary<string, object> dataDict)
	{
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	public List<Element> GetElements()
	{
		return null;
	}

	public bool GetIsInverted()
	{
		return false;
	}

	public float GetAddedProbability()
	{
		return 0f;
	}

	public override string GetDescription()
	{
		return null;
	}

	public override bool DoCharactersMeetConstraint(List<Character> characters)
	{
		return false;
	}

	public override float GetBonusChanceForCharacters(List<Character> characters)
	{
		return 0f;
	}
}
