using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Firebase
{
	public sealed class FirebaseApp : IDisposable
	{
		public class EnableModuleParams
		{
			public string CppModuleName
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string CSharpClassName
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public bool AlwaysEnable
			{
				[CompilerGenerated]
				get
				{
					return false;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public EnableModuleParams(string csharp, string cpp, bool always = false)
			{
			}
		}

		private delegate FirebaseApp CreateDelegate();

		private HandleRef swigCPtr;

		private bool swigCMemOwn;

		internal static readonly object disposeLock;

		private string name;

		private EventHandler AppDisposed;

		private static Dictionary<string, FirebaseApp> nameToProxy;

		private static Dictionary<IntPtr, FirebaseApp> cPtrToProxy;

		private static bool AppUtilCallbacksInitialized;

		private static object AppUtilCallbacksLock;

		private static bool PreventOnAllAppsDestroyed;

		private static bool crashlyticsInitializationAttempted;

		private static int CheckDependenciesThread;

		private static object CheckDependenciesThreadLock;

		public static FirebaseApp DefaultInstance => null;

		public string Name => null;

		public static LogLevel LogLevel
		{
			get
			{
				return default(LogLevel);
			}
			set
			{
			}
		}

		internal string NameInternal => null;

		public static string DefaultName => null;

		internal FirebaseApp(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		static FirebaseApp()
		{
		}

		internal static HandleRef getCPtr(FirebaseApp obj)
		{
			return default(HandleRef);
		}

		~FirebaseApp()
		{
		}

		public void Dispose()
		{
		}

		internal static void TranslateDllNotFoundException(Action closureToExecute)
		{
		}

		public static FirebaseApp GetInstance(string name)
		{
			return null;
		}

		public static FirebaseApp Create()
		{
			return null;
		}

		private void AddReference()
		{
		}

		private void RemoveReference()
		{
		}

		private static void InitializeAppUtilCallbacks()
		{
		}

		private static void OnAllAppsDestroyed()
		{
		}

		private static bool InitializeCrashlyticsIfPresent()
		{
			return false;
		}

		private static FirebaseApp CreateAndTrack(CreateDelegate createDelegate, FirebaseApp existingProxy)
		{
			return null;
		}

		private static void SetCheckDependenciesThread(int threadId)
		{
		}

		private static void ThrowIfCheckDependenciesRunning()
		{
		}

		private static bool IsCheckDependenciesRunning()
		{
			return false;
		}

		public static Task<DependencyStatus> CheckDependenciesAsync()
		{
			return null;
		}

		public static Task<DependencyStatus> CheckAndFixDependenciesAsync()
		{
			return null;
		}

		private static DependencyStatus CheckDependencies()
		{
			return default(DependencyStatus);
		}

		private static DependencyStatus CheckDependenciesInternal()
		{
			return default(DependencyStatus);
		}

		public static Task FixDependenciesAsync()
		{
			return null;
		}

		private static void ResetDefaultAppCPtr()
		{
		}

		internal static FirebaseApp CreateInternal()
		{
			return null;
		}

		internal static void ReleaseReferenceInternal(FirebaseApp app)
		{
		}

		internal static void RegisterLibraryInternal(string library, string version)
		{
		}

		internal static void AppSetDefaultConfigPath(string path)
		{
		}
	}
}
