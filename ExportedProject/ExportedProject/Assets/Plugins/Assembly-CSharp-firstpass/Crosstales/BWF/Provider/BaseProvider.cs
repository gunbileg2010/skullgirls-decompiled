using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Crosstales.BWF.Model;
using UnityEngine;

namespace Crosstales.BWF.Provider
{
	[ExecuteInEditMode]
	public abstract class BaseProvider : MonoBehaviour
	{
		public string Name;

		public RegexOptions RegexOption1;

		public RegexOptions RegexOption2;

		public RegexOptions RegexOption3;

		public RegexOptions RegexOption4;

		public RegexOptions RegexOption5;

		public Source[] Sources;

		public bool ClearOnLoad;

		protected List<string> coRoutines;

		protected static bool loggedUnsupportedPlatform;

		protected bool loading;

		public bool isReady
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public abstract void Load();

		public abstract void Save();

		protected abstract void init();

		public void Awake()
		{
		}

		protected void logNoResourcesAdded()
		{
		}
	}
}
