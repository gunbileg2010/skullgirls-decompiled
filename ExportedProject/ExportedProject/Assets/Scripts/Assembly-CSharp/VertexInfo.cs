public struct VertexInfo
{
	private const int kLargestVertexListSize = 9240;

	public static VertexInfo[] sharedVertexInfoArray;

	public byte screenBlockX;

	public byte screenBlockY;

	public byte atlasBlockX;

	public byte atlasBlockY;

	public byte blockBelowX;

	public byte blockBelowY;

	public byte blockBelowRightX;

	public byte blockBelowRightY;
}
