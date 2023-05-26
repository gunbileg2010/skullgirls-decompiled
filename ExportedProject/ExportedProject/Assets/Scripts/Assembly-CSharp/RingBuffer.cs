public class RingBuffer<T>
{
	private T[] list;

	private int head;

	private int effectiveSize;

	public int Count => 0;

	public RingBuffer()
	{
	}

	public RingBuffer(int size, T fill)
	{
	}

	public void Clear()
	{
	}

	public void Restart()
	{
	}

	public void SetSizeAndFill(int size, T fill)
	{
	}

	public void Fill(T fill)
	{
	}

	public bool Enqueue(T input)
	{
		return false;
	}

	public T GetNth(int n)
	{
		return default(T);
	}

	public T GetNthNoWrap(int n)
	{
		return default(T);
	}

	public T[] GetList()
	{
		return null;
	}

	public int GetHead()
	{
		return 0;
	}

	public void SetHead(int head)
	{
	}

	public int GetEffectiveSize()
	{
		return 0;
	}
}
