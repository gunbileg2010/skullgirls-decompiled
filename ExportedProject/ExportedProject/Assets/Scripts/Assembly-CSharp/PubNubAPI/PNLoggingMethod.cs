using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public class PNLoggingMethod
	{
		public enum Level
		{
			Off = 0,
			Error = 1,
			Info = 2,
			Verbose = 3,
			Warning = 4
		}

		private static int logLevel;

		public static Level LogLevel
		{
			get
			{
				return default(Level);
			}
			set
			{
			}
		}

		public static bool LevelError => false;

		public static bool LevelInfo => false;

		public static bool LevelVerbose => false;

		public static bool LevelWarning => false;

		public PNLogVerbosity PNLogVerb
		{
			[CompilerGenerated]
			get
			{
				return default(PNLogVerbosity);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public PNLoggingMethod(PNLogVerbosity pnLogVerbosity)
		{
		}

		public void WriteToLog(string logText, bool write)
		{
		}
	}
}
