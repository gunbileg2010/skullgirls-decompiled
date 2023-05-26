using System.Collections.Generic;

namespace Open.Nat
{
	internal class DeletePortMappingRequestMessage : RequestMessageBase
	{
		private readonly Mapping _mapping;

		public DeletePortMappingRequestMessage(Mapping mapping)
		{
		}

		public override IDictionary<string, object> ToXml()
		{
			return null;
		}
	}
}
