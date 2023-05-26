using System;
using System.Collections.Generic;

namespace UnityEngine.UDP
{
	[Serializable]
	public class ProductCatalogPersistModel
	{
		public string udpVersion;

		public List<ProductInfo> products;

		public static string Serialize(ProductCatalogPersistModel catalog)
		{
			return null;
		}

		public static ProductCatalogPersistModel Deserialize(string catalogJson)
		{
			return null;
		}

		public static ProductCatalogPersistModel FromTextAsset(TextAsset asset)
		{
			return null;
		}
	}
}
