namespace Photon.Realtime
{
	public class WebFlags
	{
		public static readonly WebFlags Default;

		public byte WebhookFlags;

		public const byte HttpForwardConst = 1;

		public const byte SendAuthCookieConst = 2;

		public const byte SendSyncConst = 4;

		public const byte SendStateConst = 8;

		public bool HttpForward => false;

		public WebFlags(byte webhookFlags)
		{
		}
	}
}
