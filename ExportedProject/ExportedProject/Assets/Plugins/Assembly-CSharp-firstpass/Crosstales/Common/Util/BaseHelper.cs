using System.Collections.Generic;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using Crosstales.Common.Model.Enum;
using UnityEngine;

namespace Crosstales.Common.Util
{
	public abstract class BaseHelper
	{
		private static readonly Regex lineEndingsRegex;

		private static readonly Regex cleanSpacesRegex;

		private static readonly Regex cleanTagsRegex;

		private const string file_prefix = "file://";

		public static bool isInternetAvailable => false;

		public static bool isWindowsPlatform => false;

		public static bool isMacOSPlatform => false;

		public static bool isLinuxPlatform => false;

		public static bool isStandalonePlatform => false;

		public static bool isAndroidPlatform => false;

		public static bool isIOSPlatform => false;

		public static bool isWSAPlatform => false;

		public static bool isWebGLPlatform => false;

		public static bool isWebPlayerPlatform => false;

		public static bool isWebPlatform => false;

		public static bool isWindowsBasedPlatform => false;

		public static bool isAppleBasedPlatform => false;

		public static bool isEditor => false;

		public static bool isEditorMode => false;

		public static Platform CurrentPlatform => default(Platform);

		public static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return false;
		}

		public static string ValidatePath(string path, bool addEndDelimiter = true)
		{
			return null;
		}

		public static string ValidateFile(string path)
		{
			return null;
		}

		public static string ValidURLFromFilePath(string path)
		{
			return null;
		}

		public static string CleanUrl(string url, bool removeProtocol = true, bool removeWWW = true, bool removeSlash = true)
		{
			return null;
		}

		public static string ClearTags(string text)
		{
			return null;
		}

		public static string ClearSpaces(string text)
		{
			return null;
		}

		public static string ClearLineEndings(string text)
		{
			return null;
		}

		public static List<string> SplitStringToLines(string text, bool ignoreCommentedLines = true, int skipHeaderLines = 0, int skipFooterLines = 0)
		{
			return null;
		}

		public static string FormatBytesToHRF(long bytes)
		{
			return null;
		}

		public static string FormatSecondsToHourMinSec(double seconds)
		{
			return null;
		}

		public static Color HSVToRGB(float h, float s, float v, float a = 1f)
		{
			return default(Color);
		}

		public static bool isValidURL(string url)
		{
			return false;
		}
	}
}
