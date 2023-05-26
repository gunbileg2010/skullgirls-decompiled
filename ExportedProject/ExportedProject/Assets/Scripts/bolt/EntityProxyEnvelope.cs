using System;
using System.Collections.Generic;
using Bolt;

internal class EntityProxyEnvelope : BoltObject, IDisposable
{
	public int PacketNumber;

	public ProxyFlags Flags;

	public EntityProxy Proxy;

	public List<Priority> Written;

	public IProtocolToken ControlTokenLost;

	public IProtocolToken ControlTokenGained;

	public void Dispose()
	{
	}
}
