using System.Reflection;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	public class ReflectionValueProvider : IValueProvider
	{
		private readonly MemberInfo _memberInfo;

		public ReflectionValueProvider(MemberInfo memberInfo)
		{
		}

		public void SetValue(object target, object value)
		{
		}

		public object GetValue(object target)
		{
			return null;
		}
	}
}
