namespace Firebase.Analytics
{
	public sealed class FirebaseAnalytics
	{
		private static FirebaseApp app;

		public static string ParameterCurrency => null;

		public static string ParameterTransactionId => null;

		public static string ParameterValue => null;

		static FirebaseAnalytics()
		{
		}

		public static void SetAnalyticsCollectionEnabled(bool enabled)
		{
		}

		public static void LogEvent(string name)
		{
		}

		public static void LogEvent(string name, params Parameter[] parameters)
		{
		}

		public static void SetUserId(string userId)
		{
		}
	}
}
