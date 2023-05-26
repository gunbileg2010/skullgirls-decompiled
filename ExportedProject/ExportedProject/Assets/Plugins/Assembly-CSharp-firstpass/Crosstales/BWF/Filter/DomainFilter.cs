using System.Collections.Generic;
using System.Text.RegularExpressions;
using Crosstales.BWF.Provider;

namespace Crosstales.BWF.Filter
{
	public class DomainFilter : BaseFilter
	{
		public string ReplaceCharacters;

		private List<DomainProvider> domainProvider;

		private readonly List<DomainProvider> tempDomainProvider;

		private readonly Dictionary<string, Regex> domainsRegex;

		private readonly Dictionary<string, List<Regex>> debugDomainsRegex;

		private bool ready;

		private bool readyFirstime;

		public List<DomainProvider> DomainProvider
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

		public DomainFilter(List<DomainProvider> domainProvider, string replaceCharacters, string markPrefix, string markPostfix)
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

		public override string Replace(string text, List<string> domains)
		{
			return null;
		}
	}
}
