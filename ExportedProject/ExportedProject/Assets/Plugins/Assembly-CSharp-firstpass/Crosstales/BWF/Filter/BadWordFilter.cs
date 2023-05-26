using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Crosstales.BWF.Provider;

namespace Crosstales.BWF.Filter
{
	public class BadWordFilter : BaseFilter
	{
		public string ReplaceCharacters;

		public bool ReplaceLeetSpeak;

		public bool SimpleCheck;

		private readonly List<BadWordProvider> tempBadWordProviderLTR;

		private readonly List<BadWordProvider> tempBadWordProviderRTL;

		private readonly Dictionary<string, Regex> exactBadwordsRegex;

		private readonly Dictionary<string, List<Regex>> debugExactBadwordsRegex;

		private readonly Dictionary<string, List<string>> simpleBadwords;

		private bool ready;

		private bool readyFirstime;

		private List<BadWordProvider> badWordProviderLTR;

		private List<BadWordProvider> badWordProviderRTL;

		private StringBuilder sb;

		public List<BadWordProvider> BadWordProviderLTR
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<BadWordProvider> BadWordProviderRTL
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool isReady => false;

		public BadWordFilter(List<BadWordProvider> badWordProviderLTR, List<BadWordProvider> badWordProviderRTL, string replaceCharacters, bool leetSpeak, bool simpleCheck, string markPrefix, string markPostfix)
		{
		}

		public override bool Contains(string testString, params string[] sources)
		{
			return false;
		}

		public override List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		public override string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		public override string Replace(string text, List<string> badWords)
		{
			return null;
		}

		protected string replaceLeetSpeak(string input)
		{
			return null;
		}
	}
}
