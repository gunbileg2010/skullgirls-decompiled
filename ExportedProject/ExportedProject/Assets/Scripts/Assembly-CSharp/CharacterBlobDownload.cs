using System;

[Serializable]
public class CharacterBlobDownload : IComparable<CharacterBlobDownload>
{
	public string name;

	public int priority;

	public CharacterBlobDownload()
	{
	}

	public CharacterBlobDownload(string name)
	{
	}

	public string GetRelativeUrl()
	{
		return null;
	}

	public string GetLocalPath(bool useEditorPaths)
	{
		return null;
	}

	public string GetAssetsFilepath()
	{
		return null;
	}

	public int CompareTo(CharacterBlobDownload other)
	{
		return 0;
	}
}
