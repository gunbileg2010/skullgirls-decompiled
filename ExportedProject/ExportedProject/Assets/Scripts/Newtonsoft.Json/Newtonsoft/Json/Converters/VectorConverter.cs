using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;
using UnityEngine;

namespace Newtonsoft.Json.Converters
{
	[Preserve]
	public class VectorConverter : JsonConverter
	{
		private static readonly Type V2;

		private static readonly Type V3;

		private static readonly Type V4;

		public bool EnableVector2
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

		public bool EnableVector3
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

		public bool EnableVector4
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

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		private static void WriteVector(JsonWriter writer, float x, float y, float? z, float? w)
		{
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		public override bool CanConvert(Type objectType)
		{
			return false;
		}

		private static Vector2 PopulateVector2(JsonReader reader)
		{
			return default(Vector2);
		}

		private static Vector3 PopulateVector3(JsonReader reader)
		{
			return default(Vector3);
		}

		private static Vector4 PopulateVector4(JsonReader reader)
		{
			return default(Vector4);
		}
	}
}
