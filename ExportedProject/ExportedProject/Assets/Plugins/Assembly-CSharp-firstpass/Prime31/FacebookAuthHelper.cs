using System;

namespace Prime31
{
	public class FacebookAuthHelper
	{
		public Action afterAuthAction;

		public bool requiresPublishPermissions;

		private static FacebookAuthHelper _instance;

		public FacebookAuthHelper(bool requiresPublishPermissions, Action afterAuthAction)
		{
		}

		~FacebookAuthHelper()
		{
		}

		public void cleanup()
		{
		}

		public void start()
		{
		}

		private void sessionOpenedEvent()
		{
		}

		private void loginFailedEvent(P31Error error)
		{
		}
	}
}
