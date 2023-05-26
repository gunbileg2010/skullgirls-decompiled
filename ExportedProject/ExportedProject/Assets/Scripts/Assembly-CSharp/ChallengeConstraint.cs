using System.Collections.Generic;

public class ChallengeConstraint
{
	private ChallengeConstraintType constraintType;

	private string value;

	private int constraintCount;

	private bool isInverted;

	private bool isRandom;

	public ChallengeConstraint(ChallengeConstraintType type, string strValue, bool random = false, bool inverted = false, int count = -1)
	{
	}

	public ChallengeConstraint(Dictionary<string, object> dataDict)
	{
	}

	public ChallengeConstraintType GetConstraintType()
	{
		return default(ChallengeConstraintType);
	}

	public string GetValue()
	{
		return null;
	}

	public int GetConstraintCount()
	{
		return 0;
	}

	public bool IsInverted()
	{
		return false;
	}

	public bool IsRandom()
	{
		return false;
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	private void ParseData(Dictionary<string, object> dataDict)
	{
	}
}
