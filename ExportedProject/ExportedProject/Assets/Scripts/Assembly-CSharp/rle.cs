public class rle
{
	public const int copy = 0;

	public const int fill = 1;

	private byte[] ptr_;

	private int ptrIndex;

	private int current_length_;

	private int current_type_;

	private byte current_value_;

	public rle()
	{
	}

	public rle(byte[] source_data, int source_data_offset, int total_size)
	{
	}

	public void reset(byte[] source_data, int source_data_offset, int total_size)
	{
	}

	public int current_type()
	{
		return 0;
	}

	public byte current_value()
	{
		return 0;
	}

	public int current_length()
	{
		return 0;
	}

	public byte[] ptr()
	{
		return null;
	}

	public int index()
	{
		return 0;
	}

	public bool advance(int n)
	{
		return false;
	}
}
