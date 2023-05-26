using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Preserve]
	public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
	{
		private readonly List<JToken> _values;

		protected override IList<JToken> ChildrenTokens => null;

		public override JTokenType Type => default(JTokenType);

		public JToken Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsReadOnly => false;

		public JArray()
		{
		}

		public JArray(JArray other)
		{
		}

		public JArray(object content)
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

		public static JArray Load(JsonReader reader)
		{
			return null;
		}

		public static JArray Load(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}

		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		internal override int IndexOfItem(JToken item)
		{
			return 0;
		}

		public int IndexOf(JToken item)
		{
			return 0;
		}

		public void Insert(int index, JToken item)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public IEnumerator<JToken> GetEnumerator()
		{
			return null;
		}

		public void Add(JToken item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(JToken item)
		{
			return false;
		}

		public void CopyTo(JToken[] array, int arrayIndex)
		{
		}

		public bool Remove(JToken item)
		{
			return false;
		}

		internal override int GetDeepHashCode()
		{
			return 0;
		}
	}
}
