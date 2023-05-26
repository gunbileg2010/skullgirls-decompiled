using Bolt;
using UdpKit;

internal static class IdExtensions
{
	public static void WritePrefabId(this UdpPacket stream, PrefabId id)
	{
	}

	public static PrefabId ReadPrefabId(this UdpPacket stream)
	{
		return default(PrefabId);
	}

	public static void WriteTypeId(this UdpPacket stream, TypeId id)
	{
	}

	public static TypeId ReadTypeId(this UdpPacket stream)
	{
		return default(TypeId);
	}
}
