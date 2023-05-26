using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	public class JsonISerializableContract : JsonContainerContract
	{
		public ObjectConstructor<object> ISerializableCreator
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public JsonISerializableContract(Type underlyingType)
			: base(null)
		{
		}
	}
}
