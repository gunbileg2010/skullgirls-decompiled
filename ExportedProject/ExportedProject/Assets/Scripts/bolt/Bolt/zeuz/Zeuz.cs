using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Bolt.zeuz
{
	public class Zeuz : MonoBehaviour
	{
		private API m_API;

		private static Zeuz m_Instance;

		private static string m_IPOverride;

		private static int m_GamePortOverride;

		private static int m_QueryPortOverride;

		private static int m_GroupIDOverride;

		private static int m_ProfileIDOverride;

		public static string ServiceID
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static string IP
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static int GamePort
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static int GroupID
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static int ProfileID
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static void SetServerOverrides(string ip, int gamePort, int queryPort = 0, int groupID = 0, int profileID = 0)
		{
		}

		public static void Initialize(bool unreserve)
		{
		}

		public static void Deinitialize(bool unreserve)
		{
		}

		private void Initialize(string accessKey, string tokenKey, bool unreserve)
		{
		}

		private void Deinitialize(bool unreserve, bool destroy)
		{
		}

		private IEnumerator Cleanup_Coroutine(bool unreserve, bool destroy)
		{
			return null;
		}

		private static void ApplyServerOverrides()
		{
		}

		private static string GetArg(string name)
		{
			return null;
		}
	}
}
