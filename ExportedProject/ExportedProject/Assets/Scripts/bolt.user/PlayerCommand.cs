using Bolt;

public class PlayerCommand : Command
{
	public IPlayerCommandInput Input => null;

	public IPlayerCommandResult Result => null;

	public IPlayerCommandLocalResult LocalResult => null;

	public static IPlayerCommandInput Create()
	{
		return null;
	}
}
