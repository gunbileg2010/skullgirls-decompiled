using System.Collections.Generic;

namespace Open.Nat
{
	internal class CreatePortMappingRequestMessage : RequestMessageBase
	{
		private readonly Mapping _mapping;

		public CreatePortMappingRequestMessage(Mapping mapping)
		{
		}

		public override IDictionary<string, object> ToXml()
		{
			return null;
		}
	}
}
