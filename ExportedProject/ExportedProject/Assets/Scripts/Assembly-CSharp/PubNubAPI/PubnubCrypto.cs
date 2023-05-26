using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public class PubnubCrypto : PubnubCryptoBase
	{
		private PNLoggingMethod pnLog
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public PubnubCrypto(string cipher_key, PNLoggingMethod pnLog)
			: base(null)
		{
		}

		public override string ComputeHashRaw(string input)
		{
			return null;
		}

		protected override string EncryptOrDecrypt(bool type, string plainStr)
		{
			return null;
		}
	}
}
