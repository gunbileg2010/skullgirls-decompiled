using System.Collections.Generic;
using UnityEngine;

public class ConstraintSet : ScriptableObject
{
	[SerializeField]
	private List<CharacterConstraintPair> bonusCharacterConstraints;

	[SerializeField]
	private List<ElementConstraintPair> bonusElementConstraints;

	[SerializeField]
	private List<TierConstraintPair> bonusTierConstraints;

	public List<KeyValuePair<string, object>> GetServerUploadData()
	{
		return null;
	}
}
