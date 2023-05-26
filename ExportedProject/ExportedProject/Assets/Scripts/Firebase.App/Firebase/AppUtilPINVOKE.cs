using System;
using System.Runtime.InteropServices;

namespace Firebase
{
	internal class AppUtilPINVOKE
	{
		protected class SWIGExceptionHelper
		{
			public delegate void ExceptionDelegate(string message);

			public delegate void ExceptionArgumentDelegate(string message, string paramName);

			private static ExceptionDelegate applicationDelegate;

			private static ExceptionDelegate arithmeticDelegate;

			private static ExceptionDelegate divideByZeroDelegate;

			private static ExceptionDelegate indexOutOfRangeDelegate;

			private static ExceptionDelegate invalidCastDelegate;

			private static ExceptionDelegate invalidOperationDelegate;

			private static ExceptionDelegate ioDelegate;

			private static ExceptionDelegate nullReferenceDelegate;

			private static ExceptionDelegate outOfMemoryDelegate;

			private static ExceptionDelegate overflowDelegate;

			private static ExceptionDelegate systemDelegate;

			private static ExceptionArgumentDelegate argumentDelegate;

			private static ExceptionArgumentDelegate argumentNullDelegate;

			private static ExceptionArgumentDelegate argumentOutOfRangeDelegate;

			static SWIGExceptionHelper()
			{
			}

			[PreserveSig]
			public static extern void SWIGRegisterExceptionCallbacks_AppUtil(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);

			[PreserveSig]
			public static extern void SWIGRegisterExceptionCallbacksArgument_AppUtil(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

			private static void SetPendingApplicationException(string message)
			{
			}

			private static void SetPendingArithmeticException(string message)
			{
			}

			private static void SetPendingDivideByZeroException(string message)
			{
			}

			private static void SetPendingIndexOutOfRangeException(string message)
			{
			}

			private static void SetPendingInvalidCastException(string message)
			{
			}

			private static void SetPendingInvalidOperationException(string message)
			{
			}

			private static void SetPendingIOException(string message)
			{
			}

			private static void SetPendingNullReferenceException(string message)
			{
			}

			private static void SetPendingOutOfMemoryException(string message)
			{
			}

			private static void SetPendingOverflowException(string message)
			{
			}

			private static void SetPendingSystemException(string message)
			{
			}

			private static void SetPendingArgumentException(string message, string paramName)
			{
			}

			private static void SetPendingArgumentNullException(string message, string paramName)
			{
			}

			private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
			{
			}
		}

		public class SWIGPendingException
		{
			[ThreadStatic]
			private static Exception pendingException;

			private static int numExceptionsPending;

			public static bool Pending => false;

			public static void Set(Exception e)
			{
			}

			public static Exception Retrieve()
			{
				return null;
			}
		}

		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			static SWIGStringHelper()
			{
			}

			[PreserveSig]
			public static extern void SWIGRegisterStringCallback_AppUtil(SWIGStringDelegate stringDelegate);

			private static string CreateString(string cString)
			{
				return null;
			}
		}

		protected static SWIGExceptionHelper swigExceptionHelper;

		protected static SWIGStringHelper swigStringHelper;

		static AppUtilPINVOKE()
		{
		}

		[PreserveSig]
		public static extern void delete_FutureBase(HandleRef jarg1);

		[PreserveSig]
		public static extern int FutureBase_status(HandleRef jarg1);

		[PreserveSig]
		public static extern int FutureBase_error(HandleRef jarg1);

		[PreserveSig]
		public static extern string FutureBase_error_message(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr FutureVoid_SWIG_OnCompletion(HandleRef jarg1, FutureVoid.SWIG_CompletionDelegate jarg2, int jarg3);

		[PreserveSig]
		public static extern void FutureVoid_SWIG_FreeCompletionData(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		public static extern void delete_FutureVoid(HandleRef jarg1);

		[PreserveSig]
		public static extern string FirebaseApp_NameInternal_get(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr FirebaseApp_CreateInternal__SWIG_0();

		[PreserveSig]
		internal static extern void FirebaseApp_ReleaseReferenceInternal(HandleRef jarg1);

		[PreserveSig]
		internal static extern void FirebaseApp_SetLogLevelInternal(int jarg1);

		[PreserveSig]
		internal static extern int FirebaseApp_GetLogLevelInternal();

		[PreserveSig]
		internal static extern void FirebaseApp_RegisterLibraryInternal(string jarg1, string jarg2);

		[PreserveSig]
		public static extern void FirebaseApp_AppSetDefaultConfigPath(string jarg1);

		[PreserveSig]
		public static extern string FirebaseApp_DefaultName_get();

		[PreserveSig]
		public static extern void PollCallbacks();

		[PreserveSig]
		public static extern void AppEnableLogCallback(bool jarg1);

		[PreserveSig]
		public static extern void SetEnabledAllAppCallbacks(bool jarg1);

		[PreserveSig]
		public static extern void SetEnabledAppCallbackByName(string jarg1, bool jarg2);

		[PreserveSig]
		public static extern bool GetEnabledAppCallbackByName(string jarg1);

		[PreserveSig]
		public static extern void SetLogFunction(LogUtil.LogMessageDelegate jarg1);

		[PreserveSig]
		public static extern int CheckAndroidDependencies();

		[PreserveSig]
		public static extern IntPtr FixAndroidDependencies();

		[PreserveSig]
		internal static extern void InitializePlayServicesInternal();

		[PreserveSig]
		internal static extern void TerminatePlayServicesInternal();

		[PreserveSig]
		public static extern IntPtr FutureVoid_SWIGUpcast(IntPtr jarg1);
	}
}
