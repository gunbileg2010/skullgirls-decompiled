using System.Collections.Generic;

public class FileFingerprints
{
	public class Fingerprint
	{
		public string hash;

		public long size;
	}

	private Dictionary<string, Fingerprint> fingerprints;

	public FileFingerprints()
	{
	}

	public FileFingerprints(string path)
	{
	}

	public void AddFingerprintsFromFile(string path)
	{
	}

	public Fingerprint GetFileFingerprint(string path)
	{
		return null;
	}

	public void Clear()
	{
	}
}
