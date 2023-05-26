using System.Collections.Generic;

namespace Prime31
{
	public class FacebookFriendsResult : FacebookBaseDTO
	{
		public List<FacebookFriend> data;

		public FacebookResultsPaging paging;
	}
}
