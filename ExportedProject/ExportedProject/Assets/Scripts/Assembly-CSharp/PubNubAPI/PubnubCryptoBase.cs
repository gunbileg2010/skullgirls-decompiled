namespace PubNubAPI
{
	public abstract class PubnubCryptoBase
	{
		private string cipherKey;

		public PubnubCryptoBase(string cipher_key)
		{
		}

		public abstract string ComputeHashRaw(string input);

		protected string GetEncryptionKey()
		{
			return null;
		}

		protected abstract string EncryptOrDecrypt(bool type, string plainStr);

		public string Encrypt(string plainText)
		{
			return null;
		}

		public string Decrypt(string cipherText)
		{
			return null;
		}

		public static string ConvertHexToUnicodeChars(string value)
		{
			return null;
		}

		protected string EncodeNonAsciiCharacters(string value)
		{
			return null;
		}

		public string PubnubAccessManagerSign(string key, string data)
		{
			return null;
		}
	}
}
