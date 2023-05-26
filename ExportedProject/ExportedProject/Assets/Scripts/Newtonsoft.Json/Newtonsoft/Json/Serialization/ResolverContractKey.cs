using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	internal struct ResolverContractKey
	{
		private readonly Type _resolverType;

		private readonly Type _contractType;

		public ResolverContractKey(Type resolverType, Type contractType)
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

		public bool Equals(ResolverContractKey other)
		{
			return false;
		}
	}
}
