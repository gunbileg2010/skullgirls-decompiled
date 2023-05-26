using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Preserve]
	internal class BsonString : BsonValue
	{
		public bool IncludeLength
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public BsonString(object value, bool includeLength)
			: base(null, default(BsonType))
		{
		}
	}
}
