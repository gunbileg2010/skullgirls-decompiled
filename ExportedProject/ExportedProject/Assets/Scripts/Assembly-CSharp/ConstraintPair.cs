using System.Collections.Generic;
using UnityEngine;

public abstract class ConstraintPair
{
	[SerializeField]
	protected float addedProbability;

	protected bool isInverted;

	protected const string kDescriptionLocKey = "Deployment_ConstraintPairs_Description";

	protected const string kInvertedDescriptionLocKey = "Deployment_ConstraintPairs_InvertedDescription";

	protected const string kColorTextOpenTag = "<color=#{0}>";

	protected const string kColorTextCloseTag = "</color>";

	public abstract string GetDescription();

	public abstract bool DoCharactersMeetConstraint(List<Character> characters);

	public abstract float GetBonusChanceForCharacters(List<Character> characters);
}
