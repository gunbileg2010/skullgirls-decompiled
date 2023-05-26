using System.IO;

namespace SevenZip.Compression.LZ
{
	public class OutWindow
	{
		private byte[] _buffer;

		private uint _pos;

		private uint _windowSize;

		private uint _streamPos;

		private Stream _stream;

		public uint TrainSize;

		public void Create(uint windowSize)
		{
		}

		public void Init(Stream stream, bool solid)
		{
		}

		public bool Train(Stream stream)
		{
			return false;
		}

		public void ReleaseStream()
		{
		}

		public void Flush()
		{
		}

		public void CopyBlock(uint distance, uint len)
		{
		}

		public void PutByte(byte b)
		{
		}

		public byte GetByte(uint distance)
		{
			return 0;
		}
	}
}
