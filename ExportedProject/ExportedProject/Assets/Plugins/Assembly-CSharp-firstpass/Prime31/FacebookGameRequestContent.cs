using System.Collections.Generic;

namespace Prime31
{
	public class FacebookGameRequestContent
	{
		private string actionType;

		public string title;

		public string message;

		public string data;

		public string objectId;

		public List<string> recipients;

		public List<string> recipientSuggestions;

		public bool frictionlessRequestsEnabled;

		public FacebookGameRequestActionType requestActionType
		{
			set
			{
			}
		}
	}
}
