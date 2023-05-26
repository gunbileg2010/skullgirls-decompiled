using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	public abstract class JsonContract
	{
		internal bool IsNullable;

		internal bool IsConvertable;

		internal bool IsEnum;

		internal Type NonNullableUnderlyingType;

		internal ReadType InternalReadType;

		internal JsonContractType ContractType;

		internal bool IsReadOnlyOrFixedSize;

		internal bool IsSealed;

		internal bool IsInstantiable;

		private List<SerializationCallback> _onDeserializedCallbacks;

		private IList<SerializationCallback> _onDeserializingCallbacks;

		private IList<SerializationCallback> _onSerializedCallbacks;

		private IList<SerializationCallback> _onSerializingCallbacks;

		private IList<SerializationErrorCallback> _onErrorCallbacks;

		private Type _createdType;

		public Type UnderlyingType
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

		public Type CreatedType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool? IsReference
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

		public JsonConverter Converter
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

		internal JsonConverter InternalConverter
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

		public IList<SerializationCallback> OnDeserializedCallbacks => null;

		public IList<SerializationCallback> OnDeserializingCallbacks => null;

		public IList<SerializationCallback> OnSerializedCallbacks => null;

		public IList<SerializationCallback> OnSerializingCallbacks => null;

		public IList<SerializationErrorCallback> OnErrorCallbacks => null;

		public Func<object> DefaultCreator
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

		public bool DefaultCreatorNonPublic
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal JsonContract(Type underlyingType)
		{
		}

		internal void InvokeOnSerializing(object o, StreamingContext context)
		{
		}

		internal void InvokeOnSerialized(object o, StreamingContext context)
		{
		}

		internal void InvokeOnDeserializing(object o, StreamingContext context)
		{
		}

		internal void InvokeOnDeserialized(object o, StreamingContext context)
		{
		}

		internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext)
		{
		}

		internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo)
		{
			return null;
		}

		internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo)
		{
			return null;
		}
	}
}
