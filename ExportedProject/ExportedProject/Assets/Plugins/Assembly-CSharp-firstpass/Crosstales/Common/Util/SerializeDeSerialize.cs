using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Crosstales.Common.Util
{
	public class SerializeDeSerialize<T>
	{
		private BinaryFormatter binaryFormatter => null;

		public void ToFile(T o, string path)
		{
		}

		public MemoryStream ToMemory(T o)
		{
			return null;
		}

		public byte[] ToByteArray(T o)
		{
			return null;
		}

		public T FromFile(string path)
		{
			return default(T);
		}

		public T FromMemory(byte[] data)
		{
			return default(T);
		}
	}
}
