using Bolt;

public class ClickToMoveCommand : Command
{
	public IClickToMoveCommandInput Input => null;

	public IClickToMoveCommandResult Result => null;

	public IClickToMoveCommandLocalResult LocalResult => null;

	public static IClickToMoveCommandInput Create()
	{
		return null;
	}
}
