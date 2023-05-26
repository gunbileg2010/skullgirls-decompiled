using System;
using System.Collections.Generic;

namespace Prime31
{
	public static class FacebookCombo
	{
		public static void init()
		{
		}

		public static string getAppLaunchUrl()
		{
			return null;
		}

		public static void login()
		{
		}

		public static void loginWithReadPermissions(string[] permissions)
		{
		}

		public static void loginWithPublishPermissions(string[] permissions)
		{
		}

		public static bool isSessionValid()
		{
			return false;
		}

		public static string getAccessToken()
		{
			return null;
		}

		public static List<object> getSessionPermissions()
		{
			return null;
		}

		public static void logout()
		{
		}

		public static void showFacebookShareDialog(FacebookShareContent parameters)
		{
		}

		public static void showGameRequestDialog(FacebookGameRequestContent content)
		{
		}

		[Obsolete]
		public static void showAppInviteDialog(string appLinkUrl, string previewImageUrl = null)
		{
		}

		public static void logEvent(string eventName, Dictionary<string, object> parameters = null)
		{
		}

		public static void logEvent(string eventName, double valueToSum, Dictionary<string, object> parameters = null)
		{
		}
	}
}
