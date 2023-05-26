using System;
using System.Collections.Generic;

namespace Bolt
{
	internal static class Factory
	{
		private static Dictionary<byte, Type> _id2token;

		private static Dictionary<Type, byte> _token2id;

		private static Dictionary<Type, IFactory> _factoriesByType;

		private static Dictionary<TypeId, IFactory> _factoriesById;

		private static Dictionary<UniqueId, IFactory> _factoriesByKey;

		internal static bool IsEmpty => false;

		internal static void Register(IFactory factory)
		{
		}

		internal static IFactory GetFactory(TypeId id)
		{
			return null;
		}

		internal static IFactory GetFactory(UniqueId id)
		{
			return null;
		}

		internal static IEventFactory GetEventFactory(TypeId id)
		{
			return null;
		}

		internal static IEventFactory GetEventFactory(UniqueId id)
		{
			return null;
		}

		internal static Event NewEvent(TypeId id)
		{
			return null;
		}

		internal static Event NewEvent(UniqueId id)
		{
			return null;
		}

		internal static byte GetTokenId(IProtocolToken obj)
		{
			return 0;
		}

		internal static IProtocolToken NewToken(byte id)
		{
			return null;
		}

		internal static Command NewCommand(TypeId id)
		{
			return null;
		}

		internal static Command NewCommand(UniqueId id)
		{
			return null;
		}

		internal static IEntitySerializer NewSerializer(TypeId id)
		{
			return null;
		}

		internal static IEntitySerializer NewSerializer(UniqueId guid)
		{
			return null;
		}

		private static object Create(TypeId id)
		{
			return null;
		}

		private static object Create(UniqueId id)
		{
			return null;
		}

		internal static void UnregisterAll()
		{
		}

		internal static void RegisterTokenClass(Type type)
		{
		}
	}
}
