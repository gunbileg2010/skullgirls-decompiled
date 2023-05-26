using System.Collections.Generic;
using System.Text.RegularExpressions;
using Crosstales.BWF.Model;

namespace Crosstales.BWF.Provider
{
	public abstract class DomainProvider : BaseProvider
	{
		protected List<Domains> domains;

		private const string domainRegexStart = "\\b{0,1}((ht|f)tp(s?)\\:\\/\\/)?[\\w\\-\\.\\@]*[\\.]";

		private const string domainRegexEnd = "(:\\d{1,5})?(\\/|\\b)";

		private Dictionary<string, Regex> domainsRegex;

		private Dictionary<string, List<Regex>> debugDomainsRegex;

		public Dictionary<string, Regex> DomainsRegex
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public Dictionary<string, List<Regex>> DebugDomainsRegex
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
