using System;

public class ManagedAIBridge
{
	private AIInputProvider aiInputProvider;

	private AIBase ai;

	public void Init(AIInputProvider aiInputProvider)
	{
	}

	public bool LoadAI(Type aiType)
	{
		return false;
	}

	public void Enable()
	{
	}

	public void Disable()
	{
	}

	public void Update()
	{
	}

	public ZInput GetInput()
	{
		return null;
	}

	public void SetDifficulty(int diff)
	{
	}

	public int GetDifficulty()
	{
		return 0;
	}

	public void SetDebug(bool debug)
	{
	}
}
