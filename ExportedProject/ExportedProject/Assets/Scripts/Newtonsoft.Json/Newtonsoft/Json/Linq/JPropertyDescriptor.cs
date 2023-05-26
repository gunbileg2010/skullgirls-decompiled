using System;
using System.ComponentModel;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Preserve]
	public class JPropertyDescriptor : PropertyDescriptor
	{
		public override Type ComponentType => null;

		public override bool IsReadOnly => false;

		public override Type PropertyType => null;

		protected override int NameHashCode => 0;

		public JPropertyDescriptor(string name)
			: base((string)null, (Attribute[])null)
		{
		}

		private static JObject CastInstance(object instance)
		{
			return null;
		}

		public override bool CanResetValue(object component)
		{
			return false;
		}

		public override object GetValue(object component)
		{
			return null;
		}

		public override void ResetValue(object component)
		{
		}

		public override void SetValue(object component, object value)
		{
		}

		public override bool ShouldSerializeValue(object component)
		{
			return false;
		}
	}
}
