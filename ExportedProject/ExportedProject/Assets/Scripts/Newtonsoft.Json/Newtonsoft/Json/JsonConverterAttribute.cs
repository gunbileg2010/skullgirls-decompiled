using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Preserve]
	public sealed class JsonConverterAttribute : Attribute
	{
		private readonly Type _converterType;

		public Type ConverterType => null;

		public object[] ConverterParameters
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
}
