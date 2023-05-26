using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Preserve]
	internal class BsonRegex : BsonToken
	{
		public BsonString Pattern
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public BsonString Options
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public override BsonType Type => default(BsonType);

		public BsonRegex(string pattern, string options)
		{
		}
	}
}
