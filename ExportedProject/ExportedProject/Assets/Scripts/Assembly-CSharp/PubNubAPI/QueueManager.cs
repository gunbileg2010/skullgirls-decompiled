using System.Runtime.CompilerServices;
using UnityEngine;

namespace PubNubAPI
{
	public class QueueManager : MonoBehaviour
	{
		public delegate void RunningRequestEndDelegate(PNOperationType operationType);

		private readonly object lockObj;

		private bool RunRequest;

		internal ushort NoOfConcurrentRequests;

		private ushort RunningRequests;

		public PubNubUnity PubNubInstance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public event RunningRequestEndDelegate RunningRequestEnd
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Start()
		{
		}

		private void UpdateRunningRequests(bool RequestComplete)
		{
		}

		private bool GetRunningRequests()
		{
			return false;
		}

		public void RaiseRunningRequestEnd(PNOperationType operationType)
		{
		}

		private void Update()
		{
		}
	}
}
