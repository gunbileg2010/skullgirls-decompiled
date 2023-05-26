using System;
using Bolt;

internal class BuildingState_Meta : Bolt.NetworkState_Meta, Bolt.ISerializerFactory, Bolt.IFactory
{
	internal static BuildingState_Meta Instance;

	internal ObjectPool<BuildingState> _pool;

	private TypeId Bolt_002EIFactory_002ETypeId => default(TypeId);

	private UniqueId Bolt_002EIFactory_002ETypeKey => default(UniqueId);

	private Type Bolt_002EIFactory_002ETypeObject => null;

	static BuildingState_Meta()
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
