using System;
using System.Globalization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	[Preserve]
	public class IsoDateTimeConverter : DateTimeConverterBase
	{
		private DateTimeStyles _dateTimeStyles;

		private string _dateTimeFormat;

		private CultureInfo _culture;

		public CultureInfo Culture => null;

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}
	}
}
