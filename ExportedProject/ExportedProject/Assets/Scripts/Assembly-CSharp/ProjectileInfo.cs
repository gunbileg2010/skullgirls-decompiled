using System.IO;
using UnityEngine;

public class ProjectileInfo
{
	public ushort type;

	public Vector2 relativeSpawnPosition;

	public bool moveWithParent;

	public SlotOpChain slotOps;

	public ProjectileInfo next;

	public void ReadFromFile(BinaryReader reader)
	{
	}

	public void Clear()
	{
	}
}
