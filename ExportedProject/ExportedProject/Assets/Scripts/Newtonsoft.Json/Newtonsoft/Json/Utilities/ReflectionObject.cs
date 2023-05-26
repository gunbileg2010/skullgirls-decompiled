using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Preserve]
	internal class ReflectionObject
	{
		public ObjectConstructor<object> Creator
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public IDictionary<string, ReflectionMember> Members
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public object GetValue(object target, string member)
		{
			return null;
		}

		public Type GetType(string member)
		{
			return null;
		}

		public static ReflectionObject Create(Type t, params string[] memberNames)
		{
			return null;
		}

		public static ReflectionObject Create(Type t, MethodBase creator, params string[] memberNames)
		{
			return null;
		}
	}
}
