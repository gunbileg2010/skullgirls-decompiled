using System;
using Bolt;

internal class LobbyCountdown_Meta : Bolt.Event_Meta, Bolt.IEventFactory, Bolt.IFactory
{
	internal static LobbyCountdown_Meta Instance;

	internal ObjectPool<LobbyCountdown> _pool;

	private TypeId Bolt_002EIFactory_002ETypeId => default(TypeId);

	private UniqueId Bolt_002EIFactory_002ETypeKey => default(UniqueId);

	private Type Bolt_002EIFactory_002ETypeObject => null;

	static LobbyCountdown_Meta()
	{
	}

	internal override void InitObject(NetworkObj obj, Bolt.NetworkObj_Meta.Offsets offsets)
	{
	}

	internal override void InitMeta()
	{
	}

	private object Bolt_002EIFactory_002ECreate()
	{
		return null;
	}

	private void Bolt_002EIFactory_002EReturn(object objToReturn)
	{
	}

	private void Bolt_002EIEventFactory_002EDispatch(Event ev, object target)
	{
	}
}
