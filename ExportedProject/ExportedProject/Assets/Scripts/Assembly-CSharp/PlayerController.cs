public class PlayerController : Controller
{
	private TouchInputProvider touchInputProvider;

	private bool allowTouchInput;

	public override void Enable()
	{
	}

	public override void Disable()
	{
	}

	public override void CleanUp()
	{
	}

	public TouchInputProvider GetTouchInputProvider()
	{
		return null;
	}

	public override ZInput GetInput()
	{
		return null;
	}

	public void SetAllowKeyboardInput(bool allow)
	{
	}

	public void SetPlayerNumber(int playerNumber)
	{
	}

	public void SetAllowTouchInput(bool allow)
	{
	}

	public override void EndSustainedInput()
	{
	}

	public override Type GetControllerType()
	{
		return default(Type);
	}
}
