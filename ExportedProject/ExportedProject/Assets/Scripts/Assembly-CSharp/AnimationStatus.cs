using System.IO;

public class AnimationStatus
{
	public int index;

	public int repeatsLeft;

	public int maxRepeats;

	public bool canHit;

	public void SaveState(BinaryWriter writer)
	{
	}

	public void LoadState(BinaryReader reader)
	{
	}
}
