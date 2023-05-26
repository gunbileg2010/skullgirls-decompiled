namespace Bolt
{
	public interface IEntityReplicationFilter
	{
		bool AllowReplicationTo(BoltConnection connection);
	}
}
