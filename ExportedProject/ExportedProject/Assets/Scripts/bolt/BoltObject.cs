using Bolt;

public class BoltObject
{
	[Documentation]
	public static implicit operator bool(BoltObject obj)
	{
		return false;
	}
}
