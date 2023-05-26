using System;

public class unrle
{
	public const int copy = 0;

	public const int fill = 1;

	private unsafe byte* ptr_;

	private int current_length_;

	private int current_type_;

	private byte current_value_;

	public unrle()
	{
	}

	public unsafe unrle(byte* source_data, int source_data_offset, int total_size)
	{
	}

	public unsafe void reset(byte* source_data, int source_data_offset, int total_size)
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

	public unsafe byte* ptr()
	{
		//IL_0002: Expected I, but got O
		return (byte*)(IntPtr)null;
	}

	public bool advance(int n)
	{
		return false;
	}
}
