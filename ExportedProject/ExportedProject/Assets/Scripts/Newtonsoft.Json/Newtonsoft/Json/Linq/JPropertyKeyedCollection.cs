using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Preserve]
	internal class JPropertyKeyedCollection : Collection<JToken>
	{
		private static readonly IEqualityComparer<string> Comparer;

		private Dictionary<string, JToken> _dictionary;

		public ICollection<string> Keys => null;

		public JPropertyKeyedCollection()
		{
			((Collection<T>)(object)this)._002Ector();
		}

		private void AddKey(string key, JToken item)
		{
		}

		protected override void ClearItems()
		{
		}

		public bool Contains(string key)
		{
			return false;
		}

		private void EnsureDictionary()
		{
		}

		private string GetKeyForItem(JToken item)
		{
			return null;
		}

		protected override void InsertItem(int index, JToken item)
		{
		}

		protected override void RemoveItem(int index)
		{
		}

		private void RemoveKey(string key)
		{
		}

		protected override void SetItem(int index, JToken item)
		{
		}

		public bool TryGetValue(string key, out JToken value)
		{
			value = null;
			return false;
		}

		public int IndexOfReference(JToken t)
		{
			return 0;
		}

		public bool Compare(JPropertyKeyedCollection other)
		{
			return false;
		}
	}
}
