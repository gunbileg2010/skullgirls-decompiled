using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Preserve]
	public sealed class JsonObjectAttribute : JsonContainerAttribute
	{
		private MemberSerialization _memberSerialization;

		internal Required? _itemRequired;

		public MemberSerialization MemberSerialization => default(MemberSerialization);
	}
}
