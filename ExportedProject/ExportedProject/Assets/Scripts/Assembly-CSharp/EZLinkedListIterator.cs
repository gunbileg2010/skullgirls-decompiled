public class EZLinkedListIterator<T> where T : IEZLinkedListItem<T>
{
	protected T cur;

	protected EZLinkedList<T> list;

	public T Current
	{
		get
		{
			return default(T);
		}
		set
		{
		}
	}

	public bool Done => false;

	public bool Begin(EZLinkedList<T> l)
	{
		return false;
	}

	public void End()
	{
	}

	public bool Next()
	{
		return false;
	}

	public bool NextNoRemove()
	{
		return false;
	}
}
