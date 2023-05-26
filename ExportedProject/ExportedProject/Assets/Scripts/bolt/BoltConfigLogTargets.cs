using System;

[Flags]
public enum BoltConfigLogTargets
{
	Unity = 1,
	Console = 2,
	File = 4,
	SystemOut = 8
}
