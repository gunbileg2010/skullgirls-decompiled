using System;
using System.Runtime.CompilerServices;

namespace Open.Nat
{
	internal class DeviceEventArgs : EventArgs
	{
		public NatDevice Device
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DeviceEventArgs(NatDevice device)
		{
		}
	}
}
