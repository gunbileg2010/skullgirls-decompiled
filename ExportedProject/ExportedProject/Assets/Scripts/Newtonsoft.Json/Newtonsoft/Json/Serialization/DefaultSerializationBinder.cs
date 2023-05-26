using System;
using System.Runtime.Serialization;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	public class DefaultSerializationBinder : SerializationBinder
	{
		internal struct TypeNameKey
		{
			internal readonly string AssemblyName;

			internal readonly string TypeName;

			public TypeNameKey(string assemblyName, string typeName)
			{
			}

			public override int GetHashCode()
			{
				return 0;
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public bool Equals(TypeNameKey other)
			{
				return false;
			}
		}

		internal static readonly DefaultSerializationBinder Instance;

		private readonly ThreadSafeStore<TypeNameKey, Type> _typeCache;

		private static Type GetTypeFromTypeNameKey(TypeNameKey typeNameKey)
		{
			return null;
		}

		public override Type BindToType(string assemblyName, string typeName)
		{
			return null;
		}
	}
}
