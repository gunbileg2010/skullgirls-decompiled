public class EZLinkedListNode<T> : IEZLinkedListItem<EZLinkedListNode<T>>
{
	public T val;

	private EZLinkedListNode<T> m_prev;

	private EZLinkedListNode<T> m_next;

	public EZLinkedListNode<T> prev
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public EZLinkedListNode<T> next
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public EZLinkedListNode(T v)
	{
	}
}
