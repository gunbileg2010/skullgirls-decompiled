using System.Collections.Generic;
using Crosstales.Common.Model.Enum;
using UnityEngine;

namespace Crosstales.Common.Util
{
	public class PlatformController : MonoBehaviour
	{
		public List<Platform> Platforms;

		public bool Active;

		public GameObject[] Objects;

		protected Platform currentPlatform;

		public virtual void Start()
		{
		}

		protected void selectPlatform()
		{
		}

		protected void activateGO()
		{
		}
	}
}
