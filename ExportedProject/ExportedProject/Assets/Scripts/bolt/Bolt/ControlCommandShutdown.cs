using System;
using System.Collections.Generic;
using UdpKit;

namespace Bolt
{
	internal class ControlCommandShutdown : ControlCommand
	{
		public List<Action> Callbacks;

		public UdpConnectionDisconnectReason disconnectReason;

		public override void Run()
		{
		}

		public override void Done()
		{
		}
	}
}
