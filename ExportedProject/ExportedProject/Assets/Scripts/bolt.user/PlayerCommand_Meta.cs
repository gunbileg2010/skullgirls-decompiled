using System;
using Bolt;

internal class PlayerCommand_Meta : Bolt.Command_Meta, Bolt.ICommandFactory, Bolt.IFactory
{
	internal static PlayerCommand_Meta Instance;

	internal ObjectPool<PlayerCommand> _pool;

	private TypeId Bolt_002EIFactory_002ETypeId => default(TypeId);

	private UniqueId Bolt_002EIFactory_002ETypeKey => default(UniqueId);

	private Type Bolt_002EIFactory_002ETypeObject => null;

	static PlayerCommand_Meta()
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
