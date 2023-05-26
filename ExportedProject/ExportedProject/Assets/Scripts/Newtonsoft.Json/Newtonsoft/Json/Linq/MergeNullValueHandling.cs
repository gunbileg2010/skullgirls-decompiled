using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Preserve]
	[Flags]
	public enum MergeNullValueHandling
	{
		Ignore = 0,
		Merge = 1
	}
}
