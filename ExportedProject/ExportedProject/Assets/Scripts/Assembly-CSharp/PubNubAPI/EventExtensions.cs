using System;

namespace PubNubAPI
{
	internal static class EventExtensions
	{
		public static void Raise<T>(this EventHandler<T> handler, object sender, T args) where T : EventArgs
		{
		}
	}
}
