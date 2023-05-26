using System;
using System.Collections.Generic;
using UnityEngine;

namespace Prime31
{
	public class FacebookAndroid
	{
		private static AndroidJavaObject _facebookPlugin;

		static FacebookAndroid()
		{
		}

		internal static void babysitRequest(bool requiresPublishPermissions, Action afterAuthAction)
		{
		}

		public static void init(bool printKeyHash = true)
		{
		}

		public static string getAppLaunchUrl()
		{
			return null;
		}

		public static void setSessionLoginBehavior(FacebookSessionLoginBehavior loginBehavior)
		{
		}

		public static void setDefaultAudience(FacebookSessionDefaultAudience defaultAudience)
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

		public static void login()
		{
		}

		public static void loginWithReadPermissions(string[] permissions)
		{
		}

		public static void loginWithPublishPermissions(string[] permissions)
		{
		}

		public static void logout()
		{
		}

		public static void showFacebookShareDialog(FacebookShareContent parameters)
		{
		}

		[Obsolete]
		public static void showAppInviteDialog(string appLinkUrl, string previewImageUrl = null)
		{
		}

		public static void showGameRequestDialog(FacebookGameRequestContent content)
		{
		}

		public static void graphRequest(string graphPath, string httpMethod, Dictionary<string, string> parameters)
		{
		}

		public static void logEvent(string eventName, Dictionary<string, object> parameters = null)
		{
		}

		public static void logPurchaseEvent(double amount, string currency)
		{
		}

		public static void logEvent(string eventName, double valueToSum, Dictionary<string, object> parameters = null)
		{
		}
	}
}
