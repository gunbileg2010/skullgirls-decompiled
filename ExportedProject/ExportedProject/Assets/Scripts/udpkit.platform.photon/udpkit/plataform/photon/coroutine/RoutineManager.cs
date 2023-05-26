using System.Collections.Generic;
using UnityEngine;

namespace udpkit.plataform.photon.coroutine
{
	internal static class RoutineManager
	{
		private static readonly object _locker;

		private static Dictionary<long, IEnumerator<CustomYieldInstruction>> _coroutines;

		private static List<long> _markRemove;

		private static long _idx;

		static RoutineManager()
		{
		}

		public static void Init()
		{
		}

		public static long StartCoroutine(IEnumerator<CustomYieldInstruction> enumerator)
		{
			return 0L;
		}

		public static void StopCoroutine(long idx)
		{
		}

		public static void Service()
		{
		}
	}
}
