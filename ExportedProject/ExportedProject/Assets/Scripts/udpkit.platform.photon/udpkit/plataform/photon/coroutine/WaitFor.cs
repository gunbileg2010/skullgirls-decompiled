using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace udpkit.plataform.photon.coroutine
{
	internal class WaitFor : CustomYieldInstruction
	{
		private readonly Stopwatch _stopwatch;

		public override bool keepWaiting => false;

		public float WaitTime
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public WaitFor(float waitMillis)
		{
		}

		public new void Reset()
		{
		}

		public void Start()
		{
		}
	}
}
