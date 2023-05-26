using System.IO;
using UnityEngine;

public static class BinaryReaderWriterExtensions
{
	public static void Write(this BinaryWriter writer, Vector3 vector3)
	{
	}

	public static Vector3 ReadVector3(this BinaryReader reader)
	{
		return default(Vector3);
	}

	public static void Write(this BinaryWriter writer, Bounds bounds)
	{
	}

	public static Bounds ReadBounds(this BinaryReader reader)
	{
		return default(Bounds);
	}

	public static void Write(this BinaryWriter writer, Rect rect)
	{
	}

	public static Rect ReadRect(this BinaryReader reader)
	{
		return default(Rect);
	}

	public static void Write(this BinaryWriter writer, Color32 color)
	{
	}

	public static Color32 ReadColor32(this BinaryReader reader)
	{
		return default(Color32);
	}

	public static void Write(this BinaryWriter writer, Color color)
	{
	}

	public static Color ReadColor(this BinaryReader reader)
	{
		return default(Color);
	}
}
