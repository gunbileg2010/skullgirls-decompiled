using System;
using System.Runtime.Serialization;

namespace Open.Nat
{
	[Serializable]
	public class NatDeviceNotFoundException : Exception
	{
		public NatDeviceNotFoundException()
		{
		}

		public NatDeviceNotFoundException(string message)
		{
		}

		public NatDeviceNotFoundException(string message, Exception innerException)
		{
		}

		protected NatDeviceNotFoundException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
