using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Crosstales.BWF.Filter
{
	public class PunctuationFilter : BaseFilter
	{
		private int characterNumber;

		public Regex RegularExpression
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int CharacterNumber
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override bool isReady => false;

		public PunctuationFilter(int punctuationCharacterNumber, string markPrefix, string markPostfix)
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
	}
}
