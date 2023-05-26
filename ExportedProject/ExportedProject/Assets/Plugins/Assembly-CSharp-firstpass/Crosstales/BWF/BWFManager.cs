using System.Collections.Generic;
using Crosstales.BWF.Model;
using UnityEngine;

namespace Crosstales.BWF
{
	[ExecuteInEditMode]
	public class BWFManager : MonoBehaviour
	{
		private GameObject root;

		public static bool isReady => false;

		public void OnEnable()
		{
		}

		public void Update()
		{
		}

		public static void Load(ManagerMask mask = ManagerMask.All)
		{
		}

		public static List<Source> Sources(ManagerMask mask = ManagerMask.All)
		{
			return null;
		}

		public static bool Contains(string testString, ManagerMask mask = ManagerMask.All, params string[] sources)
		{
			return false;
		}

		public static void ContainsMT(out bool result, ref string testString, ManagerMask mask = ManagerMask.All, params string[] sources)
		{
			result = default(bool);
		}

		public static List<string> GetAll(string testString, ManagerMask mask = ManagerMask.All, params string[] sources)
		{
			return null;
		}

		public static void GetAllMT(out List<string> result, ref string testString, ManagerMask mask = ManagerMask.All, params string[] sources)
		{
			result = null;
		}

		public static string ReplaceAll(string testString, ManagerMask mask = ManagerMask.All, params string[] sources)
		{
			return null;
		}

		public static void ReplaceAllMT(out string result, ref string testString, ManagerMask mask = ManagerMask.All, params string[] sources)
		{
			result = null;
		}

		public static string Replace(string text, List<string> unwantedWords, ManagerMask mask = ManagerMask.All)
		{
			return null;
		}

		public static string Mark(string text, List<string> unwantedWords, string prefix = "<b><color=red>", string postfix = "</color></b>")
		{
			return null;
		}

		public static string Unmark(string text, string prefix = "<b><color=red>", string postfix = "</color></b>")
		{
			return null;
		}
	}
}
