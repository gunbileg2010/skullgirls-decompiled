using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Flags]
	[Preserve]
	public enum DefaultValueHandling
	{
		Include = 0,
		Ignore = 1,
		Populate = 2,
		IgnoreAndPopulate = 3
	}
}
