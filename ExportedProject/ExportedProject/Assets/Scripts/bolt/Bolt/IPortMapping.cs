namespace Bolt
{
	public interface IPortMapping
	{
		ushort External { get; }

		ushort Internal { get; }

		NatPortMappingStatus Status { get; }
	}
}
