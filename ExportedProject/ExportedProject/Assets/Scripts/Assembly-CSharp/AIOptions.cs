using System;
using System.Collections;
using System.Collections.Generic;

public class AIOptions
{
	private List<Func<IEnumerator>> options;

	private List<float> shares;

	private float totalShares;

	public void Add(float share, Func<IEnumerator> action)
	{
	}

	public void Remove(Func<IEnumerator> action)
	{
	}

	public void Clear()
	{
	}

	public bool IsEmpty()
	{
		return false;
	}

	public Func<IEnumerator> Select()
	{
		return null;
	}

	public IEnumerator SelectAndRun()
	{
		return null;
	}

	public void Print()
	{
	}
}
