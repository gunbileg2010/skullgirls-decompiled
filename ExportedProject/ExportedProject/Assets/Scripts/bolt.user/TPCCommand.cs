using Bolt;

public class TPCCommand : Command
{
	public ITPCCommandInput Input => null;

	public ITPCCommandResult Result => null;

	public ITPCCommandLocalResult LocalResult => null;

	public static ITPCCommandInput Create()
	{
		return null;
	}
}
