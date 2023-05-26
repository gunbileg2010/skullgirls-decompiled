using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class AniFrame
{
	private struct OneImage
	{
		public CompressedImage main;

		public CompressedImage mask;

		public IntVector2 cropOffset;
	}

	private static uint headPointHashName;

	private static uint shoulderPointHashName;

	private static uint hipsPointHashName;

	private static uint kneesPointHashName;

	private static uint feetPointHashName;

	private static uint throwVictimPointHashName;

	private OneImage commonPic;

	private OneImage mainDiffPic;

	private OneImage altDiffPic;

	private IntVector2 centerPoint;

	private List<Bounds>[] boxes;

	private Dictionary<uint, IntVector2> otherPoints;

	private ArtMemoryType artMemoryType;

	public void ReadFromFile(BinaryReader reader)
	{
	}

	public void Clear()
	{
	}

	public CompressedImage GetPic(PicType picType)
	{
		return null;
	}

	public CompressedImage GetMaskedPic(PicType picType)
	{
		return null;
	}

	public ArtMemoryType GetArtMemoryType()
	{
		return default(ArtMemoryType);
	}

	public void SetArtMemoryType(ArtMemoryType type)
	{
	}

	public Vector2 GetCenterPoint(PicType whichOne = PicType.COMMON_PIC)
	{
		return default(Vector2);
	}

	public Vector2 GetCenterPoint(AniFrame frameWithCenterPoint, PicType whichOne = PicType.COMMON_PIC)
	{
		return default(Vector2);
	}

	public Vector2 GetOtherPoint(PointType pointType)
	{
		return default(Vector2);
	}

	public Vector2 GetOtherPointByHashedName(uint hashedName, bool raw = false)
	{
		return default(Vector2);
	}

	public List<Bounds> GetBoxes(BoxType type)
	{
		return null;
	}

	public bool HasAltPic()
	{
		return false;
	}
}
