using Bolt;

[Documentation]
public struct BoltIterator<T> where T : class, IBoltListNode<T>
{
	private T _node;

	private int _count;

	private int _number;

	public T val;

	public BoltIterator(T node, int count)
	{
	}

	public bool Next()
	{
		return false;
	}

	public bool Next(out T item)
	{
		item = null;
		return false;
	}
}
