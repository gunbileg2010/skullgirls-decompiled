public class atlas
{
	public const int BLOCK_HEIGHT = 16;

	public const int BLOCK_WIDTH = 16;

	public const int BLOCK_SIZE = 256;

	public const int finished = 0;

	public const int need_more = 1;

	public const int at_line_begin_need_more = 2;

	private int num_blocks_;

	private int first_block_x_;

	private int first_block_y_;

	private int width_in_bytes_;

	private int bytes_left_in_block_sequence_;

	private int bytes_left_in_current_row_;

	private int current_line_offset;

	private int last_line_offset;

	private byte[] atlasBuffer;

	private int currentAtlasOffset;

	public atlas()
	{
	}

	public atlas(byte[] bufferIn, int bufferOffset, int blocksToDecode, int first_block_index, int width_in_blocks)
	{
	}

	public void reset(byte[] bufferIn, int bufferOffset, int blocksToDecode, int first_block_index, int width_in_blocks)
	{
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

	public byte[] prev_line_ptr()
	{
		return null;
	}

	public int prev_line_index()
	{
		return 0;
	}

	public byte[] prev_prev_line_ptr()
	{
		return null;
	}

	public int prev_prev_line_index()
	{
		return 0;
	}

	public byte[] prev_line_ptr_mutable()
	{
		return null;
	}

	public int advance(int n)
	{
		return 0;
	}
}
