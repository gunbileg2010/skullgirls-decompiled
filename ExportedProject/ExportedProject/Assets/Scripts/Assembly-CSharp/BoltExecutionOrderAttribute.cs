using System;

public sealed class BoltExecutionOrderAttribute : Attribute
{
	private readonly int _executionOrder;

	public int executionOrder => 0;

	public BoltExecutionOrderAttribute(int order)
	{
	}
}
