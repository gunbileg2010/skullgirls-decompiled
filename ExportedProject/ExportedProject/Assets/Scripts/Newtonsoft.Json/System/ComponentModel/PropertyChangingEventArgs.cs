using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace System.ComponentModel
{
	[Preserve]
	public class PropertyChangingEventArgs : EventArgs
	{
		public virtual string PropertyName
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public PropertyChangingEventArgs(string propertyName)
		{
		}
	}
}
