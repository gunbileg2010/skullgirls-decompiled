namespace udpkit.plataform.photon.puncher
{
	internal class StunMsgHeader
	{
		public uint Type;

		public uint Length;

		public uint Magic;

		public byte[] TS_ID;

		public StunMsgHeader(uint type = 0u, uint length = 0u, uint magic = 0u, byte[] ts_id = null)
		{
		}

		public byte[] Encode()
		{
			return null;
		}

		public StunMsgHeader Decode(byte[] data)
		{
			return null;
		}
	}
}
