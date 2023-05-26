using System.Collections.Generic;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Preserve]
	public class JConstructor : JContainer
	{
		private string _name;

		private readonly List<JToken> _values;

		protected override IList<JToken> ChildrenTokens => null;

		public string Name => null;

		public override JTokenType Type => default(JTokenType);

		internal override int IndexOfItem(JToken item)
		{
			return 0;
		}

		public JConstructor()
		{
		}

		public JConstructor(JConstructor other)
		{
		}

		public JConstructor(string name)
		{
		}

		internal override bool DeepEquals(JToken node)
		{
			return false;
		}

		internal override JToken CloneToken()
		{
			return null;
		}

		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		internal override int GetDeepHashCode()
		{
			return 0;
		}

		public static JConstructor Load(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}
	}
}
