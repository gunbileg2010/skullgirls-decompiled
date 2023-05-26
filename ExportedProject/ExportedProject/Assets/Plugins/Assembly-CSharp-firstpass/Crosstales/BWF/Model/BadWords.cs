using System;
using System.Collections.Generic;

namespace Crosstales.BWF.Model
{
	[Serializable]
	public class BadWords
	{
		public Source Source;

		public List<string> BadWordList;

		public BadWords(Source source, List<string> badWordList)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
