using System;
using System.Runtime.CompilerServices;

public static class ClientAPI
{
	private const string kSavedBackendOverrideUrlKey = "savedBackendOverrideUrl";

	private const string kSavedBackendKey = "savedBackend";

	private const string localUrl = "http://localhost:9000";

	private const string devUrl = "http://dev-skullgirls.hiddenvariable.com";

	private const string qaUrl = "http://qa-temp-skullgirls.hiddenvariable.com";

	private const string stagingUrl = "https://skgm-test-game-api.skullgirlsmobile.com";

	private const string autumnReleaseUrl = "https://skgm-prod-game-api.skullgirlsmobile.com";

	private const string apiVersion = "v1";

	private static string baseUrl;

	private static string customOverrideUrl;

	private static string signatureSecret;

	private static BackendEnvironment environment;

	public static event Action<BackendEnvironment> EnvironmentChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	static ClientAPI()
	{
	}

	public static void ResetToDefaultBackend()
	{
	}

	public static BackendEnvironment GetEnvironment()
	{
		return default(BackendEnvironment);
	}

	public static void SetEnvironment(BackendEnvironment newEnvironment, string url = null)
	{
	}

	public static bool IsUsingCustomBackendUrl()
	{
		return false;
	}

	public static void RememberCustomBackendConfig()
	{
	}

	public static void ForgetCustomBackendConfig()
	{
	}

	public static string GetUrl(string endpoint = null)
	{
		return null;
	}

	public static string GetRelativeUrl(string endpoint = null)
	{
		return null;
	}

	public static string IsolateEndpoint(string url)
	{
		return null;
	}

	public static string GetSignatureSecret()
	{
		return null;
	}

	private static void SetBaseUrl(string newBaseUrl)
	{
	}
}
