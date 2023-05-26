namespace Bolt
{
	internal interface IEventFactory : IFactory
	{
		void Dispatch(Event ev, object target);
	}
}
