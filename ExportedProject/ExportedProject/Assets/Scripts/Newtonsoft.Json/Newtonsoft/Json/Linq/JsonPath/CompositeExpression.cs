using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	[Preserve]
	internal class CompositeExpression : QueryExpression
	{
		public List<QueryExpression> Expressions
		{
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
