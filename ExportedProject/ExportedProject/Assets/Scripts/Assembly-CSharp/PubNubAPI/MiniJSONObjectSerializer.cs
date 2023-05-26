using System.Collections.Generic;

namespace PubNubAPI
{
	public class MiniJSONObjectSerializer : IJsonLibrary
	{
		private PubNubUnityBase pnUnityBase;

		public MiniJSONObjectSerializer(PubNubUnityBase pnUnityBase)
		{
		}

		public bool IsArrayCompatible(string jsonString)
		{
			return false;
		}

		public bool IsDictionaryCompatible(string jsonString)
		{
			return false;
		}

		public string SerializeToJsonString(object objectToSerialize)
		{
			return null;
		}

		public List<object> DeserializeToListOfObject(string jsonString)
		{
			return null;
		}

		public object DeserializeToObject(string jsonString)
		{
			return null;
		}

		public Dictionary<string, object> DeserializeToDictionaryOfObject(string jsonString)
		{
			return null;
		}
	}
}
