public class AutoplayController : Controller
{
	private TouchInputProvider touchInputProvider;

	private AIInputProvider aiInputProvider;

	private const int kAutoplayDifficulty = 3;

	public AutoplayController(AIProfile aiProfile, int playerNumber)
	{
	}

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

	public void SetDebugAI(bool debug)
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
