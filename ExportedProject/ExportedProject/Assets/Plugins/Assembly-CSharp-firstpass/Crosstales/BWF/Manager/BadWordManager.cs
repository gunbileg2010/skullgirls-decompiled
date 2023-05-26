using System.Collections.Generic;
using Crosstales.BWF.Filter;
using Crosstales.BWF.Model;
using Crosstales.BWF.Provider;
using UnityEngine;

namespace Crosstales.BWF.Manager
{
	[DisallowMultipleComponent]
	public class BadWordManager : BaseManager
	{
		public string ReplaceChars;

		public bool ReplaceLeetSpeak;

		public bool SimpleCheck;

		public List<BadWordProvider> BadWordProviderLTR;

		public List<BadWordProvider> BadWordProviderRTL;

		private static bool initalized;

		private static BadWordFilter filter;

		private static BadWordManager manager;

		private static bool loggedFilterIsNull;

		private static bool loggedOnlyOneInstance;

		private const string clazz = "BadWordManager";

		public static string ReplaceCharacters
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool isReplaceLeetSpeak
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool isSimpleCheck
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool isReady => false;

		public static List<Source> Sources => null;

		public void OnEnable()
		{
		}

		public static void Load()
		{
		}

		public static bool Contains(string testString, params string[] sources)
		{
			return false;
		}

		public static void ContainsMT(out bool result, string testString, params string[] sources)
		{
			result = default(bool);
		}

		public static List<string> GetAll(string testString, params string[] sources)
		{
			return null;
		}

		public static void GetAllMT(out List<string> result, string testString, params string[] sources)
		{
			result = null;
		}

		public static string ReplaceAll(string testString, params string[] sources)
		{
			return null;
		}

		public static void ReplaceAllMT(out string result, string testString, params string[] sources)
		{
			result = null;
		}

		public static string Replace(string text, List<string> badWords)
		{
			return null;
		}

		public static string Mark(string text, List<string> badWords, string prefix = "<b><color=red>", string postfix = "</color></b>")
		{
			return null;
		}

		public static string Unmark(string text, string prefix = "<b><color=red>", string postfix = "</color></b>")
		{
			return null;
		}

		private static void logFilterIsNull(string clazz)
		{
		}
	}
}
