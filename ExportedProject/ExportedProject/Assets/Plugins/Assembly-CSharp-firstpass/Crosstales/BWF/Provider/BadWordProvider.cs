using System.Collections.Generic;
using System.Text.RegularExpressions;
using Crosstales.BWF.Model;

namespace Crosstales.BWF.Provider
{
	public abstract class BadWordProvider : BaseProvider
	{
		protected List<BadWords> badwords;

		private const string exactRegexStart = "(?<![\\w\\d])";

		private const string exactRegexEnd = "s?(?![\\w\\d])";

		private Dictionary<string, Regex> exactBadwordsRegex;

		private Dictionary<string, List<Regex>> debugExactBadwordsRegex;

		private Dictionary<string, List<string>> simpleBadwords;

		public Dictionary<string, Regex> ExactBadwordsRegex
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public Dictionary<string, List<Regex>> DebugExactBadwordsRegex
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public Dictionary<string, List<string>> SimpleBadwords
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public override void Load()
		{
		}

		protected override void init()
		{
		}
	}
}
