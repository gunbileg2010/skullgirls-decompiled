using System.Threading.Tasks;

namespace Firebase
{
	internal class AppUtil
	{
		internal static void PollCallbacks()
		{
		}

		internal static void AppEnableLogCallback(bool arg0)
		{
		}

		internal static void SetEnabledAllAppCallbacks(bool arg0)
		{
		}

		internal static void SetEnabledAppCallbackByName(string arg0, bool arg1)
		{
		}

		internal static bool GetEnabledAppCallbackByName(string arg0)
		{
			return false;
		}

		internal static void SetLogFunction(LogUtil.LogMessageDelegate arg0)
		{
		}

		public static GooglePlayServicesAvailability CheckAndroidDependencies()
		{
			return default(GooglePlayServicesAvailability);
		}

		public static Task FixAndroidDependenciesAsync()
		{
			return null;
		}

		internal static void InitializePlayServicesInternal()
		{
		}

		internal static void TerminatePlayServicesInternal()
		{
		}
	}
}
