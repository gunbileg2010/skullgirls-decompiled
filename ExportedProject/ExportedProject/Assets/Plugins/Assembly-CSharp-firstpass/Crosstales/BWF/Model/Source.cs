using System;
using UnityEngine;

namespace Crosstales.BWF.Model
{
	[Serializable]
	public class Source
	{
		public string Name;

		public string Description;

		public Sprite Icon;

		public string URL;

		public TextAsset Resource;

		public override string ToString()
		{
			return null;
		}
	}
}
