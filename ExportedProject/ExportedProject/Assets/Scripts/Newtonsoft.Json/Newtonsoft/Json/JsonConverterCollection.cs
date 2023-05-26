using System.Collections.ObjectModel;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Preserve]
	public class JsonConverterCollection : Collection<JsonConverter>
	{
		public JsonConverterCollection()
		{
			((Collection<T>)(object)this)._002Ector();
		}
	}
}
