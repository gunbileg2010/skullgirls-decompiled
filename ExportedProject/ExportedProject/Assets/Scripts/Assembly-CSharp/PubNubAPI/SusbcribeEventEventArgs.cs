using System;

namespace PubNubAPI
{
	internal class SusbcribeEventEventArgs : EventArgs
	{
		public PNStatus Status;

		public PNPresenceEventResult PresenceEventResult;

		public PNMessageResult MessageResult;
	}
}
