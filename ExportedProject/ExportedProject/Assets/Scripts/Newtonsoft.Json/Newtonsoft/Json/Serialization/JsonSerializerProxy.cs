using System;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	internal class JsonSerializerProxy : JsonSerializer
	{
		private readonly JsonSerializerInternalReader _serializerReader;

		private readonly JsonSerializerInternalWriter _serializerWriter;

		private readonly JsonSerializer _serializer;

		public override IReferenceResolver ReferenceResolver
		{
			set
			{
			}
		}

		public override ITraceWriter TraceWriter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override IEqualityComparer EqualityComparer
		{
			set
			{
			}
		}

		public override JsonConverterCollection Converters => null;

		public override DefaultValueHandling DefaultValueHandling
		{
			set
			{
			}
		}

		public override IContractResolver ContractResolver
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override MissingMemberHandling MissingMemberHandling
		{
			set
			{
			}
		}

		public override NullValueHandling NullValueHandling
		{
			set
			{
			}
		}

		public override ObjectCreationHandling ObjectCreationHandling
		{
			get
			{
				return default(ObjectCreationHandling);
			}
			set
			{
			}
		}

		public override ReferenceLoopHandling ReferenceLoopHandling
		{
			set
			{
			}
		}

		public override PreserveReferencesHandling PreserveReferencesHandling
		{
			set
			{
			}
		}

		public override TypeNameHandling TypeNameHandling
		{
			set
			{
			}
		}

		public override MetadataPropertyHandling MetadataPropertyHandling
		{
			get
			{
				return default(MetadataPropertyHandling);
			}
			set
			{
			}
		}

		public override FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			set
			{
			}
		}

		public override ConstructorHandling ConstructorHandling
		{
			set
			{
			}
		}

		public override SerializationBinder Binder
		{
			set
			{
			}
		}

		public override StreamingContext Context
		{
			get
			{
				return default(StreamingContext);
			}
			set
			{
			}
		}

		public override Formatting Formatting => default(Formatting);

		public override bool CheckAdditionalContent => false;

		public override event EventHandler<ErrorEventArgs> Error
		{
			add
			{
			}
			remove
			{
			}
		}

		internal JsonSerializerInternalBase GetInternalSerializer()
		{
			return null;
		}

		public JsonSerializerProxy(JsonSerializerInternalReader serializerReader)
		{
		}

		public JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter)
		{
		}

		internal override object DeserializeInternal(JsonReader reader, Type objectType)
		{
			return null;
		}

		internal override void PopulateInternal(JsonReader reader, object target)
		{
		}

		internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType)
		{
		}
	}
}
