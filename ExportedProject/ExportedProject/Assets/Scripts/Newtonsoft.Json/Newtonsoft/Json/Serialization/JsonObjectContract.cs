using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	public class JsonObjectContract : JsonContainerContract
	{
		internal bool ExtensionDataIsJToken;

		private bool? _hasRequiredOrDefaultValueProperties;

		private ConstructorInfo _parametrizedConstructor;

		private ConstructorInfo _overrideConstructor;

		private ObjectConstructor<object> _overrideCreator;

		private ObjectConstructor<object> _parameterizedCreator;

		private JsonPropertyCollection _creatorParameters;

		private Type _extensionDataValueType;

		public MemberSerialization MemberSerialization
		{
			[CompilerGenerated]
			get
			{
				return default(MemberSerialization);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Required? ItemRequired
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

		public JsonPropertyCollection Properties
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

		public JsonPropertyCollection CreatorParameters => null;

		[Obsolete]
		public ConstructorInfo OverrideConstructor
		{
			set
			{
			}
		}

		[Obsolete]
		public ConstructorInfo ParametrizedConstructor
		{
			set
			{
			}
		}

		public ObjectConstructor<object> OverrideCreator => null;

		internal ObjectConstructor<object> ParameterizedCreator => null;

		public ExtensionDataSetter ExtensionDataSetter
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

		public ExtensionDataGetter ExtensionDataGetter
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

		public Type ExtensionDataValueType
		{
			set
			{
			}
		}

		internal bool HasRequiredOrDefaultValueProperties => false;

		public JsonObjectContract(Type underlyingType)
			: base(null)
		{
		}

		internal object GetUninitializedObject()
		{
			return null;
		}
	}
}
