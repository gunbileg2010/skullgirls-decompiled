using UnityEngine;

public class EditorFighterScoreCalculatorAttribute : PropertyAttribute
{
	public string fieldName;

	public bool isList;

	public float fighterFSMultiplierAddition;

	public EditorFighterScoreCalculatorAttribute(string fieldName, bool isList)
	{
	}

	public EditorFighterScoreCalculatorAttribute(string fieldName, bool isList, float fighterFSMultiplierAddition)
	{
	}
}
