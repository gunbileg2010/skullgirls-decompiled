using System;
using Bolt;

internal class LobbyCommandLocalResult_Meta : Bolt.NetworkObj_Meta, Bolt.IFactory
{
	internal static LobbyCommandLocalResult_Meta Instance;

	internal ObjectPool<LobbyCommandLocalResult> _pool;

	private TypeId Bolt_002EIFactory_002ETypeId => default(TypeId);

	private UniqueId Bolt_002EIFactory_002ETypeKey => default(UniqueId);

	private Type Bolt_002EIFactory_002ETypeObject => null;

	static LobbyCommandLocalResult_Meta()
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
}
