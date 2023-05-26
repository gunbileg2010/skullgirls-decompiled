using Bolt;

[Documentation]
public interface IBoltListNode<T> where T : class
{
	T prev { get; set; }

	T next { get; set; }

	object list { get; set; }
}
