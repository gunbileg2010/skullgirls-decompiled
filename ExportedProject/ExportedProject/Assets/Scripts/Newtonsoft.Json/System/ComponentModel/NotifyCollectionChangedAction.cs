using Newtonsoft.Json.Shims;

namespace System.ComponentModel
{
	[Preserve]
	public enum NotifyCollectionChangedAction
	{
		Add = 0,
		Remove = 1,
		Replace = 2,
		Move = 3,
		Reset = 4
	}
}
