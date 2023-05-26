public class AIInputProvider : InputProvider
{
	private ManagedAIBridge aiBridge;

	private bool aiLoadError;

	private AIProfile currentAIProfile;

	private int playerNumber;

	private bool debugAI;

	public override void Enable()
	{
	}

	public override void Disable()
	{
	}

	public override void Update()
	{
	}

	public override ZInput GetInput()
	{
		return null;
	}

	public void SetAI(AIProfile aiProfile)
	{
	}

	public void SetPlayerNumber(int playerNumber)
	{
	}

	public int GetPlayerNumber()
	{
		return 0;
	}

	public void SetDebug(bool debugFlag)
	{
	}

	public void SetDifficulty(int diff)
	{
	}

	public int GetDifficulty()
	{
		return 0;
	}

	public bool IsDebug()
	{
		return false;
	}
}
