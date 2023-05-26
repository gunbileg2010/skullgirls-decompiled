using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Preserve]
	public class BsonWriter : JsonWriter
	{
		private BsonToken _root;

		private BsonToken _parent;

		private string _propertyName;

		private void AddValue(object value, BsonType type)
		{
		}

		internal void AddToken(BsonToken token)
		{
		}

		public void WriteObjectId(byte[] value)
		{
		}

		public void WriteRegex(string pattern, string options)
		{
		}
	}
}
