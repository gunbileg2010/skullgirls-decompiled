using System.Collections.Generic;

namespace Bolt.zeuz
{
	internal class Auth
	{
		private readonly string m_AccessKey;

		private readonly string m_TokenKey;

		private string m_Date;

		internal Auth(string accessKey, string tokenKey)
		{
		}

		internal string GetAuthorizationHeader(string url, IList<object> parameters)
		{
			return null;
		}

		internal string GetDate()
		{
			return null;
		}

		private string GenerateSignature(string url, IList<object> parameters)
		{
			return null;
		}

		private string GetStringToSign(string url, IList<object> parameters)
		{
			return null;
		}

		private string GetHMACSHA512(string input, string key)
		{
			return null;
		}

		private string ByteArrayToHexString(byte[] bytes)
		{
			return null;
		}
	}
}
