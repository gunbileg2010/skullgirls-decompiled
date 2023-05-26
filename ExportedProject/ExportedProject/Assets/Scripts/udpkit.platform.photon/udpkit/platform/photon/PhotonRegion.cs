using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace udpkit.platform.photon
{
	public class PhotonRegion
	{
		public enum Regions
		{
			BEST_REGION = 0,
			ASIA = 1,
			AU = 2,
			CAE = 3,
			CN = 4,
			EU = 5,
			IN = 6,
			JP = 7,
			RU = 8,
			RUE = 9,
			SA = 10,
			KR = 11,
			US = 12,
			USW = 13
		}

		public static Dictionary<Regions, PhotonRegion> regions;

		public string Code
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string Name
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string City
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Regions Region
		{
			[CompilerGenerated]
			get
			{
				return default(Regions);
			}
		}

		public static PhotonRegion GetRegion(string regionCode)
		{
			return null;
		}

		public static PhotonRegion GetRegion(Regions targetRegion)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		static PhotonRegion()
		{
		}

		private PhotonRegion(string code, string name, string city, Regions region)
		{
		}
	}
}
