using Bolt;

public interface IPlayerCommandInput : INetworkCommandData
{
	bool forward { get; set; }

	bool backward { get; set; }

	bool left { get; set; }

	bool right { get; set; }

	bool jump { get; set; }

	float yaw { get; set; }

	float pitch { get; set; }

	bool aiming { get; set; }

	bool fire { get; set; }

	int weapon { get; set; }
}
