using System.Collections.Generic;

namespace ExitGames.Client.Photon
{
	public abstract class IProtocol
	{
		public abstract string ProtocolType { get; }

		public abstract byte[] VersionBytes { get; }

		public abstract void Serialize(StreamBuffer dout, object serObject, bool setType);

		public abstract void SerializeShort(StreamBuffer dout, short serObject, bool setType);

		public abstract void SerializeString(StreamBuffer dout, string serObject, bool setType);

		public abstract void SerializeEventData(StreamBuffer stream, EventData serObject, bool setType);

		public abstract void SerializeOperationRequest(StreamBuffer stream, byte operationCode, Dictionary<byte, object> parameters, bool setType);

		public abstract void SerializeOperationResponse(StreamBuffer stream, OperationResponse serObject, bool setType);

		public abstract object Deserialize(StreamBuffer din, byte type);

		public abstract short DeserializeShort(StreamBuffer din);

		public abstract byte DeserializeByte(StreamBuffer din);

		public abstract EventData DeserializeEventData(StreamBuffer din);

		public abstract OperationRequest DeserializeOperationRequest(StreamBuffer din);

		public abstract OperationResponse DeserializeOperationResponse(StreamBuffer stream);

		public byte[] Serialize(object obj)
		{
			return null;
		}

		public object DeserializeMessage(StreamBuffer stream)
		{
			return null;
		}
	}
}
