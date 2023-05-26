public class KeyboardInputProvider : InputProvider
{
	private int playerNumber;

	private bool ignoreSustainedInput;

	public override ZInput GetInput()
	{
		return null;
	}

	public void SetPlayerNumber(int playerNumber)
	{
	}

	public override void EndSustainedInput()
	{
	}
}
