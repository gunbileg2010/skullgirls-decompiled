using System.Collections.Generic;

public class RiftBattleIndividualmailFormatter : MailFormatter
{
	public const string kWonResultLineKey = "Mail_RiftBattle_BattleInstanceCleared_Victory";

	public const string kLossResultLineKey = "Mail_RiftBattle_BattleInstanceCleared_Defeat";

	public override string GetBody(string body, Dictionary<string, string> metadata)
	{
		return null;
	}
}
