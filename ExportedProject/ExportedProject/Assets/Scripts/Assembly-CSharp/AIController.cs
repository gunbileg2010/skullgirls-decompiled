public class AIController : Controller
{
	private AIInputProvider aiInputProvider;

	public AIController(AIProfile aiProfile)
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

	public void SetAI(AIProfile aiProfile)
	{
	}

	public void SetDifficulty(int diff)
	{
	}

	public int GetDifficulty()
	{
		return 0;
	}

	public void SetDisableAI(bool disable)
	{
	}

	public void SetDebugAI(bool debug)
	{
	}

	public override Type GetControllerType()
	{
		return default(Type);
	}
}
