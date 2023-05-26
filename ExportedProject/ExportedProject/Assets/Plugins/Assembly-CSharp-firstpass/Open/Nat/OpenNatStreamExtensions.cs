using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Xml;

namespace Open.Nat
{
	internal static class OpenNatStreamExtensions
	{
		internal static string ReadAsMany(this StreamReader stream, int bytesToRead)
		{
			return null;
		}

		internal static string GetXmlElementText(this XmlNode node, string elementName)
		{
			return null;
		}

		internal static bool ContainsIgnoreCase(this string s, string pattern)
		{
			return false;
		}

		internal static void LogInfo(this TraceSource source, string format, params object[] args)
		{
		}

		internal static void LogWarn(this TraceSource source, string format, params object[] args)
		{
		}

		internal static void LogError(this TraceSource source, string format, params object[] args)
		{
		}

		internal static string ToPrintableXml(this XmlDocument document)
		{
			return null;
		}

		public static Task<TResult> TimeoutAfter<TResult>(this Task<TResult> task, TimeSpan timeout)
		{
			return null;
		}
	}
}
