using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public abstract class PubNubNonSubBuilder<U, V> where V : class
	{
		protected delegate void RunRequestDelegate(QueueManager qm);

		protected delegate void CreateResponseDelegate(object deSerializedResult, RequestState pnRequestState);

		protected Action<V, PNStatus> Callback;

		protected PubNubUnity PubNubInstance;

		protected List<string> ChannelGroupsToUse
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

		protected List<string> ChannelsToUse
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

		public PNOperationType OperationType
		{
			[CompilerGenerated]
			get
			{
				return default(PNOperationType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected event RunRequestDelegate RunRequest
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

		protected event CreateResponseDelegate CreateResponse
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

		protected PubNubNonSubBuilder(PubNubUnity pn, PNOperationType pnOperationType)
		{
		}

		internal void RaiseRunRequest(QueueManager qm)
		{
		}

		internal void RaiseCreateResponse(object createResponse, RequestState pnRequestState)
		{
		}

		internal void RaiseError(PNStatusCategory pnStatusCategory, Exception exception, bool showInCallback, RequestState pnRequestState)
		{
		}

		internal void RaiseError(PNStatus pnStatus)
		{
		}

		protected abstract void CreatePubNubResponse(object deSerializedResult, RequestState pnRequestState);

		protected void CreateErrorResponse(PNStatusCategory pnStatusCategory, Exception exception, bool showInCallback, RequestState pnRequestState)
		{
		}

		protected PNStatus CreateErrorResponseFromMessage(string message, RequestState pnRequestState, PNStatusCategory pnStatusCategory)
		{
			return null;
		}

		protected PNStatus CreateStatusResponseFromMessage(bool isError, string message, RequestState pnRequestState, PNStatusCategory pnStatusCategory)
		{
			return null;
		}

		protected PNStatus CreateErrorResponseFromException(Exception ex, RequestState pnRequestState, PNStatusCategory pnStatusCategory)
		{
			return null;
		}

		protected abstract void RunWebRequest(QueueManager qm);

		public void Async(PubNubNonSubBuilder<U, V> pnBuilder)
		{
		}

		protected void RunWebRequest(QueueManager qm, Uri request, RequestState requestState, int timeout, int pause, PubNubNonSubBuilder<U, V> pnBuilder)
		{
		}
	}
}
