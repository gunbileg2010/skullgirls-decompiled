using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Preserve]
	public enum ReferenceLoopHandling
	{
		Error = 0,
		Ignore = 1,
		Serialize = 2
	}
}
