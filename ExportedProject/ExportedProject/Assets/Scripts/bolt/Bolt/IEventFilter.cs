namespace Bolt
{
	public interface IEventFilter
	{
		bool EventReceived(Event ev);
	}
}
