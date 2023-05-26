using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Condition : MonoBehaviour
{
	public string id;

	public LogicalOperator logicalOperator;

	public bool not;

	public bool enemy;

	public bool point;

	[HideInInspector]
	public Randomizer randomGenerator;

	public virtual void Update()
	{
	}

	public static bool Evaluate(List<Condition> conditions, object context)
	{
		return false;
	}

	public virtual bool Evaluate(object context)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public string GetRelevantActorString()
	{
		return null;
	}

	public virtual void SaveState(BinaryWriter writer)
	{
	}

	public virtual void LoadState(BinaryReader reader)
	{
	}

	public virtual bool CompareStates(BinaryReader readerA, BinaryReader readerB)
	{
		return false;
	}

	protected bool Compare(float left, ComparisonOperator op, float right)
	{
		return false;
	}

	protected bool EvaluateNot(bool value)
	{
		return false;
	}
}
