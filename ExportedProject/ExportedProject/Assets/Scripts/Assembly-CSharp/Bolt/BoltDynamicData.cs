using System;
using System.Collections.Generic;
using System.Reflection;

namespace Bolt
{
	public static class BoltDynamicData
	{
		private static readonly string ASSEMBLY_CSHARP;

		private static readonly string ASSEMBLY_CSHARP_FIRST;

		public static void Setup()
		{
		}

		private static int GetSceneIndex(string name)
		{
			return 0;
		}

		private static string GetSceneName(int index)
		{
			return null;
		}

		public static List<STuple<BoltGlobalBehaviourAttribute, Type>> GetGlobalBehaviourTypes()
		{
			return null;
		}

		private static Assembly GetAssemblyByName(string name)
		{
			return null;
		}
	}
}
