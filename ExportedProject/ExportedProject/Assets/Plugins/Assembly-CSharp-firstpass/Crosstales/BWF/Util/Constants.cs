using System;
using Crosstales.Common.Util;

namespace Crosstales.BWF.Util
{
	public abstract class Constants : BaseConstants
	{
		public static readonly bool isPro;

		public const string ASSET_NAME = "BWF PRO";

		public const string ASSET_VERSION = "2.9.10";

		public const int ASSET_BUILD = 2910;

		public static readonly DateTime ASSET_CREATED;

		public static readonly DateTime ASSET_CHANGED;

		public const string ASSET_PRO_URL = "https://www.assetstore.unity3d.com/#!/content/74688?aid=1011lNGT&pubref=BWF PRO";

		public const string ASSET_UPDATE_CHECK_URL = "https://www.crosstales.com/media/assets/bwf_versions.txt";

		public const string ASSET_CONTACT = "bwf@crosstales.com";

		public const string ASSET_MANUAL_URL = "https://www.crosstales.com/media/data/assets/badwordfilter/BadWordFilter-doc.pdf";

		public const string ASSET_API_URL = "http://goo.gl/QkE2sN";

		public const string ASSET_FORUM_URL = "http://goo.gl/Mj9XpS";

		public const string ASSET_WEB_URL = "https://www.crosstales.com/en/portfolio//badwordfilter/";

		public const string ASSET_VIDEO_PROMO = "https://youtu.be/pXICeRKaRPM?list=PLgtonIOr6Tb41XTMeeZ836tjHlKgOO84S";

		public const string ASSET_VIDEO_TUTORIAL = "https://youtu.be/W8FxFlIObWM?list=PLgtonIOr6Tb41XTMeeZ836tjHlKgOO84S";

		public const string KEY_PREFIX = "BWF_CFG_";

		public const string KEY_DEBUG = "BWF_CFG_DEBUG";

		public const string KEY_DEBUG_BADWORDS = "BWF_CFG_DEBUG_BADWORDS";

		public const string KEY_DEBUG_DOMAINS = "BWF_CFG_DEBUG_DOMAINS";

		public const bool DEFAULT_DEBUG_BADWORDS = false;

		public const bool DEFAULT_DEBUG_DOMAINS = false;

		public const string MANAGER_SCENE_OBJECT_NAME = "BWF";
	}
}
