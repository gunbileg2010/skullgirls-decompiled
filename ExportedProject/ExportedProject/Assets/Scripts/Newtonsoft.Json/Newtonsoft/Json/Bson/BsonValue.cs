using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Preserve]
	internal class BsonValue : BsonToken
	{
		private readonly object _value;

		private readonly BsonType _type;

		public override BsonType Type => default(BsonType);

		public BsonValue(object value, BsonType type)
		{
		}
	}
}
