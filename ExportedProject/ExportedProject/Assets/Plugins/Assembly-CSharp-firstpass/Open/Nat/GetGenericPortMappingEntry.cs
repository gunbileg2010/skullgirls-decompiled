using System.Collections.Generic;

namespace Open.Nat
{
	internal class GetGenericPortMappingEntry : RequestMessageBase
	{
		private readonly int _index;

		public GetGenericPortMappingEntry(int index)
		{
		}

		public override IDictionary<string, object> ToXml()
		{
			return null;
		}
	}
}
