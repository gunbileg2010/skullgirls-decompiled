using System;

[Flags]
public enum BoltNetworkModes
{
	None = 0,
	[Obsolete]
	Host = 1,
	Server = 1,
	Client = 2,
	Shutdown = 3
}
