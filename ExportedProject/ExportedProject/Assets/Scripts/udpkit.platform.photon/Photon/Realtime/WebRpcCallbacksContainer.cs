using System;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

namespace Photon.Realtime
{
	internal class WebRpcCallbacksContainer : IWebRpcCallback
	{
		internal event Action<OperationResponse> OnWebRpcResponseActions
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

		public void AddCallbackTarget(IWebRpcCallback target)
		{
		}

		public void RemoveCallbackTarget(IWebRpcCallback target)
		{
		}

		public void OnWebRpcResponse(OperationResponse response)
		{
		}
	}
}
