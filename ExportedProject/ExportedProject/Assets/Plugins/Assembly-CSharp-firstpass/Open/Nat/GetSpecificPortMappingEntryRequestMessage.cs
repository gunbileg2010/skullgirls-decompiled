using System.Collections.Generic;

namespace Open.Nat
{
	internal class GetSpecificPortMappingEntryRequestMessage : RequestMessageBase
	{
		private readonly int _externalPort;

		private readonly Protocol _protocol;

		public GetSpecificPortMappingEntryRequestMessage(Protocol protocol, int externalPort)
		{
		}

		public override IDictionary<string, object> ToXml()
		{
			return null;
		}
	}
}
