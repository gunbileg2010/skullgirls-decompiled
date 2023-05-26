using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;

namespace Bolt.zeuz
{
	internal class API
	{
		private const string API_BASE = "https://api.zeuz.io/v2";

		private const string API_SERVICE = "https://api.zeuz.io/v2/service/{0}";

		private const string API_RESERVE = "https://api.zeuz.io/v2/service/reserve";

		private const string API_UNRESERVE = "https://api.zeuz.io/v2/service/unreserve";

		private const string API_PROVIDE = "https://api.zeuz.io/v2/service/provide/{0}/{1}";

		private const string API_ALLOCATE = "https://api.zeuz.io/v2/service/allocate";

		private const string API_UNALLOCATE = "https://api.zeuz.io/v2/service/unallocate/{0}";

		private const string API_STATUS = "https://api.zeuz.io/v2/service/status/{0}";

		private const string API_LISTSERVICES = "https://api.zeuz.io/v2/service/listServices/{0}/{1}";

		private const string API_START = "https://api.zeuz.io/v2/service/start/{0}";

		private const string API_STOP = "https://api.zeuz.io/v2/service/stop/{0}";

		private const string API_RESTART = "https://api.zeuz.io/v2/service/restart/{0}";

		private const string API_REINSTALL = "https://api.zeuz.io/v2/service/reinstall/{0}";

		private const string API_STATISTICS = "https://api.zeuz.io/v2/statistics/ccu/{0}";

		private const string PARAMETER_SERVICE_ID = "serviceId";

		private const string PARAMETER_GAME_PROFILE_ID = "gameProfileId";

		private const string PARAMETER_SERVER_GROUP_ID = "serverGroupId";

		private const string PARAMETER_HOST_NAME = "hostName";

		private const string PARAMETER_MAX_PLAYER_COUNT = "maxPlayerCount";

		private const string PARAMETER_PLAYER_COUNT = "playerCount";

		private const string PARAMETER_MAP = "map";

		private const string PARAMETER_BOT_COUNT = "botCount";

		private const string PARAMETER_ATTEMPTS = "attempts";

		private const string PARAMETER_LATENCY = "latency";

		private const string CONTENT_TYPE_JSON = "application/json";

		private const string HEADER_AUTHORIZATION = "Authorization";

		private const string HEADER_CONTENT_TYPE = "Content-Type";

		private const string HEADER_DATE = "X-ZEUZ-DATE";

		private readonly Auth m_Auth;

		public API(string accessKey, string tokenKey)
		{
		}

		public IEnumerator Unreserve(string serviceId)
		{
			return null;
		}

		private UnityWebRequest POST(string url, string body, Dictionary<string, object> parameters)
		{
			return null;
		}

		public static void FillParameterValues(IEnumerable source, IList<object> target)
		{
		}
	}
}
