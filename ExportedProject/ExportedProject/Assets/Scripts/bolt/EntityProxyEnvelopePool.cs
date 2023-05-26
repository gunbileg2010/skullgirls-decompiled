using System.Collections.Generic;

internal static class EntityProxyEnvelopePool
{
	private static readonly Stack<EntityProxyEnvelope> pool;

	internal static EntityProxyEnvelope Acquire()
	{
		return null;
	}

	internal static void Release(EntityProxyEnvelope obj)
	{
	}
}
