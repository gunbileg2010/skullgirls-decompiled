using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Preserve]
	public class JsonSerializerSettings
	{
		internal static readonly StreamingContext DefaultContext;

		internal static readonly CultureInfo DefaultCulture;

		internal Formatting? _formatting;

		internal DateFormatHandling? _dateFormatHandling;

		internal DateTimeZoneHandling? _dateTimeZoneHandling;

		internal DateParseHandling? _dateParseHandling;

		internal FloatFormatHandling? _floatFormatHandling;

		internal FloatParseHandling? _floatParseHandling;

		internal StringEscapeHandling? _stringEscapeHandling;

		internal CultureInfo _culture;

		internal bool? _checkAdditionalContent;

		internal int? _maxDepth;

		internal bool _maxDepthSet;

		internal string _dateFormatString;

		internal bool _dateFormatStringSet;

		internal FormatterAssemblyStyle? _typeNameAssemblyFormat;

		internal DefaultValueHandling? _defaultValueHandling;

		internal PreserveReferencesHandling? _preserveReferencesHandling;

		internal NullValueHandling? _nullValueHandling;

		internal ObjectCreationHandling? _objectCreationHandling;

		internal MissingMemberHandling? _missingMemberHandling;

		internal ReferenceLoopHandling? _referenceLoopHandling;

		internal StreamingContext? _context;

		internal ConstructorHandling? _constructorHandling;

		internal TypeNameHandling? _typeNameHandling;

		internal MetadataPropertyHandling? _metadataPropertyHandling;

		public ReferenceLoopHandling ReferenceLoopHandling => default(ReferenceLoopHandling);

		public MissingMemberHandling MissingMemberHandling => default(MissingMemberHandling);

		public ObjectCreationHandling ObjectCreationHandling => default(ObjectCreationHandling);

		public NullValueHandling NullValueHandling => default(NullValueHandling);

		public DefaultValueHandling DefaultValueHandling => default(DefaultValueHandling);

		public IList<JsonConverter> Converters
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

		public PreserveReferencesHandling PreserveReferencesHandling => default(PreserveReferencesHandling);

		public TypeNameHandling TypeNameHandling => default(TypeNameHandling);

		public MetadataPropertyHandling MetadataPropertyHandling => default(MetadataPropertyHandling);

		public FormatterAssemblyStyle TypeNameAssemblyFormat => default(FormatterAssemblyStyle);

		public ConstructorHandling ConstructorHandling => default(ConstructorHandling);

		public IContractResolver ContractResolver
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public IEqualityComparer EqualityComparer
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Func<IReferenceResolver> ReferenceResolverProvider
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public ITraceWriter TraceWriter
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public SerializationBinder Binder
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public EventHandler<ErrorEventArgs> Error
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public StreamingContext Context => default(StreamingContext);

		static JsonSerializerSettings()
		{
		}
	}
}
