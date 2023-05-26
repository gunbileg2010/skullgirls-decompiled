using System;
using Bolt;

internal class ClickToMoveCommandInput_Meta : Bolt.NetworkObj_Meta, Bolt.IFactory
{
	internal static ClickToMoveCommandInput_Meta Instance;

	internal ObjectPool<ClickToMoveCommandInput> _pool;

	private TypeId Bolt_002EIFactory_002ETypeId => default(TypeId);

	private UniqueId Bolt_002EIFactory_002ETypeKey => default(UniqueId);

	private Type Bolt_002EIFactory_002ETypeObject => null;

	static ClickToMoveCommandInput_Meta()
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
