using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Preserve]
	internal abstract class BsonToken
	{
		public abstract BsonType Type { get; }

		public BsonToken Parent
		{
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
