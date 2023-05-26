using System.IO;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Preserve]
	internal class Base64Encoder
	{
		private readonly char[] _charsLine;

		private readonly TextWriter _writer;

		private byte[] _leftOverBytes;

		private int _leftOverBytesCount;

		public Base64Encoder(TextWriter writer)
		{
		}

		public void Encode(byte[] buffer, int index, int count)
		{
		}

		public void Flush()
		{
		}

		private void WriteChars(char[] chars, int index, int count)
		{
		}
	}
}
