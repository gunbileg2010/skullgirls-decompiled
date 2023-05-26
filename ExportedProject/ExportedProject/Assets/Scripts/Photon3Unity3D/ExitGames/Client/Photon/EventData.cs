using System.Collections.Generic;

namespace ExitGames.Client.Photon
{
	public class EventData
	{
		public byte Code;

		public Dictionary<byte, object> Parameters;

		private static byte SenderKey;

		private int sender;

		private static byte CustomDataKey;

		public int Sender => 0;

		public object CustomData => null;

		public object Item => null;

		public override string ToString()
		{
			return null;
		}
	}
}
