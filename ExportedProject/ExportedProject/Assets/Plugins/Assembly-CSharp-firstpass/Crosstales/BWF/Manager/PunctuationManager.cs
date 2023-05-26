using System.Collections.Generic;
using Crosstales.BWF.Filter;
using UnityEngine;

namespace Crosstales.BWF.Manager
{
	[DisallowMultipleComponent]
	public class PunctuationManager : BaseManager
	{
		public int PunctuationCharsNumber;

		private static bool initalized;

		private static PunctuationFilter filter;

		private static PunctuationManager manager;

		private static bool loggedFilterIsNull;

		private static bool loggedOnlyOneInstance;

		private const string clazz = "PunctuationManager";

		public static int CharacterNumber
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static bool isReady => false;

		public void OnEnable()
		{
		}

		public void OnValidate()
		{
		}

		public static void Load()
		{
		}

		public static bool Contains(string testString)
		{
			return false;
		}

		public static void ContainsMT(out bool result, string testString)
		{
			result = default(bool);
		}

		public static List<string> GetAll(string testString)
		{
			return null;
		}

		public static void GetAllMT(out List<string> result, string testString)
		{
			result = null;
		}

		public static string ReplaceAll(string testString)
		{
			return null;
		}

		public static void ReplaceAllMT(out string result, string testString)
		{
			result = null;
		}

		public static string Replace(string text, List<string> punctuations)
		{
			return null;
		}

		public static string Mark(string text, List<string> punctuations, string prefix = "<b><color=red>", string postfix = "</color></b>")
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
