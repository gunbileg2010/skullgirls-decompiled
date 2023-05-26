using System.Collections.Generic;

namespace PubNubAPI
{
	public interface IJsonLibrary
	{
		bool IsArrayCompatible(string jsonString);

		bool IsDictionaryCompatible(string jsonString);

		string SerializeToJsonString(object objectToSerialize);

		List<object> DeserializeToListOfObject(string jsonString);

		object DeserializeToObject(string jsonString);

		Dictionary<string, object> DeserializeToDictionaryOfObject(string jsonString);
	}
}
