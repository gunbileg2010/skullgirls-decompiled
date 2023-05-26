namespace UdpKit
{
	internal class UdpEventSessionSetHostData : UdpEventBase
	{
		public string Name;

		public byte[] Token;

		public object TokenObject;

		public bool Dedicated;

		public override int Type => 0;
	}
}
