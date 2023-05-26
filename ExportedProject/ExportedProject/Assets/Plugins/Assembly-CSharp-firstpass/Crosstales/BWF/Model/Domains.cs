using System;
using System.Collections.Generic;

namespace Crosstales.BWF.Model
{
	[Serializable]
	public class Domains
	{
		public Source Source;

		public List<string> DomainList;

		public Domains(Source source, List<string> domainList)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
