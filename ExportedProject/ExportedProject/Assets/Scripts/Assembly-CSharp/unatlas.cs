using System;

public class unatlas
{
	public const int BLOCK_HEIGHT = 16;

	public const int BLOCK_WIDTH = 16;

	public const int BLOCK_SIZE = 256;

	public const int finished = 0;

	public const int need_more = 1;

	public const int at_line_begin_need_more = 2;

	public const int kBPP = 4;

	public const int kBPP2X = 8;

	private int num_blocks_;

	private int first_block_x_;

	private int first_block_y_;

	private int width_in_bytes_;

	private int bytes_left_in_block_sequence_;

	private int bytes_left_in_current_row_;

	private unsafe byte* current_line_;

	private unsafe byte* last_line_;

	private unsafe byte* ptr_;

	public unatlas()
	{
	}

	public unsafe unatlas(byte* bufferIn, int bufferOffset, int blocksToDecode, int firstBlockIndex, int widthInBlocks)
	{
	}

	public unsafe void reset(byte* bufferIn, int bufferOffset, int blocksToDecode, int firstBlockIndex, int widthInBlocks)
	{
	}

	public int current_length()
	{
		return 0;
	}

	public unsafe byte* ptr()
	{
		//IL_0002: Expected I, but got O
		return (byte*)(IntPtr)null;
	}

	public unsafe byte* prev_line_ptr()
	{
		//IL_0002: Expected I, but got O
		return (byte*)(IntPtr)null;
	}

	public unsafe byte* prev_line_ptr_mutable()
	{
		//IL_0002: Expected I, but got O
		return (byte*)(IntPtr)null;
	}

	public unsafe byte* prev_prev_line_ptr()
	{
		//IL_0002: Expected I, but got O
		return (byte*)(IntPtr)null;
	}

	public int advance(int n)
	{
		return 0;
	}
}
