using System.Collections.Generic;
using Crosstales.BWF.Model;

namespace Crosstales.BWF.Filter
{
	public abstract class BaseFilter
	{
		public string MarkPrefix;

		public string MarkPostfix;

		protected Dictionary<string, Source> sources;

		public virtual List<Source> Sources => null;

		public abstract bool isReady { get; }

		public abstract bool Contains(string testString, params string[] sources);

		public abstract List<string> GetAll(string testString, params string[] sources);

		public abstract string ReplaceAll(string testString, params string[] sources);

		public abstract string Replace(string text, List<string> badWords);

		public virtual string Mark(string text, List<string> badWords, string prefix = "<b><color=red>", string postfix = "</color></b>")
		{
			return null;
		}

		public virtual string Unmark(string text, string prefix = "<b><color=red>", string postfix = "</color></b>")
		{
			return null;
		}

		protected void logFilterNotReady()
		{
		}

		protected void logResourceNotFound(string res)
		{
		}

		protected void logContains()
		{
		}

		protected void logGetAll()
		{
		}

		protected void logReplaceAll()
		{
		}

		protected void logReplace()
		{
		}
	}
}
