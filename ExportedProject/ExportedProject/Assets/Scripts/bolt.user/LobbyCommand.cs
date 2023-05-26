using Bolt;

public class LobbyCommand : Command
{
	public ILobbyCommandInput Input => null;

	public ILobbyCommandResult Result => null;

	public ILobbyCommandLocalResult LocalResult => null;

	public static ILobbyCommandInput Create()
	{
		return null;
	}
}
