using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Preserve]
	internal static class ConvertUtils
	{
		internal struct TypeConvertKey
		{
			private readonly Type _initialType;

			private readonly Type _targetType;

			public Type InitialType => null;

			public Type TargetType => null;

			public TypeConvertKey(Type initialType, Type targetType)
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

			public bool Equals(TypeConvertKey other)
			{
				return false;
			}
		}

		internal enum ConvertResult
		{
			Success = 0,
			CannotConvertNull = 1,
			NotInstantiableType = 2,
			NoValidConversion = 3
		}

		private static readonly Dictionary<Type, PrimitiveTypeCode> TypeCodeMap;

		private static readonly TypeInformation[] PrimitiveTypeCodes;

		private static readonly ThreadSafeStore<TypeConvertKey, Func<object, object>> CastConverters;

		public static PrimitiveTypeCode GetTypeCode(Type t)
		{
			return default(PrimitiveTypeCode);
		}

		public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum)
		{
			isEnum = default(bool);
			return default(PrimitiveTypeCode);
		}

		public static TypeInformation GetTypeInformation(IConvertible convertable)
		{
			return null;
		}

		public static bool IsConvertible(Type t)
		{
			return false;
		}

		public static TimeSpan ParseTimeSpan(string input)
		{
			return default(TimeSpan);
		}

		private static Func<object, object> CreateCastConverter(TypeConvertKey t)
		{
			return null;
		}

		private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object value)
		{
			value = null;
			return false;
		}

		private static ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, out object value)
		{
			value = null;
			return default(ConvertResult);
		}

		public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType)
		{
			return null;
		}

		private static object EnsureTypeAssignable(object value, Type initialType, Type targetType)
		{
			return null;
		}

		internal static TypeConverter GetConverter(Type t)
		{
			return null;
		}

		public static bool VersionTryParse(string input, out Version result)
		{
			result = null;
			return false;
		}

		public static bool IsInteger(object value)
		{
			return false;
		}

		public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value)
		{
			value = default(int);
			return default(ParseResult);
		}

		public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value)
		{
			value = default(long);
			return default(ParseResult);
		}

		public static bool TryConvertGuid(string s, out Guid g)
		{
			g = default(Guid);
			return false;
		}

		public static int HexTextToInt(char[] text, int start, int end)
		{
			return 0;
		}

		private static int HexCharToInt(char ch)
		{
			return 0;
		}
	}
}
