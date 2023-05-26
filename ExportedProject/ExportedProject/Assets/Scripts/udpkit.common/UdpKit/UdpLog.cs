namespace UdpKit
{
	public static class UdpLog
	{
		public delegate void Writer(uint level, string message);

		public const uint ERROR = 0u;

		public const uint INFO = 1u;

		public const uint DEBUG = 4u;

		public const uint TRACE = 8u;

		public const uint WARN = 16u;

		private static uint enabled;

		private static Writer writer;

		private static readonly object sync;

		private static void Write(uint level, string message)
		{
		}

		public static void Info(string format, params object[] args)
		{
		}

		public static void Trace(string format, params object[] args)
		{
		}

		public static void Debug(string format, params object[] args)
		{
		}

		public static void Warn(string format, params object[] args)
		{
		}

		public static void Error(string format, params object[] args)
		{
		}

		public static void SetWriter(Writer callback)
		{
		}

		public static void Disable(uint flag)
		{
		}

		public static void Enable(uint flag)
		{
		}
	}
}
