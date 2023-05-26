using System.Collections.Generic;
using System.IO;

public class PaletteMap
{
	public class ColorBandInfo
	{
		public byte numColors;

		public byte colorStartIndex;

		public bool noLight;

		public bool noRimLight;
	}

	private enum PMapVersion
	{
		V1 = 0,
		V2 = 1,
		Invalid = 2
	}

	private List<ColorBandInfo> colorBands;

	private Dictionary<byte, byte> indexRemap;

	public void ReadFromFile(BinaryReader reader)
	{
	}

	public byte GetBandIndexRedirectIfExists(byte rawBandIndex)
	{
		return 0;
	}

	public ColorBandInfo GetColorBandInfo(int bandIndex)
	{
		return null;
	}

	public int GetNumBands()
	{
		return 0;
	}
}
