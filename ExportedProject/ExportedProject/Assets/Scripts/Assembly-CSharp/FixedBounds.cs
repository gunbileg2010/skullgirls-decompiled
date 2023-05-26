using System;
using UnityEngine;

[Serializable]
public struct FixedBounds
{
	private Fixed3 _center;

	private Fixed3 _extents;

	public Fixed3 center
	{
		get
		{
			return default(Fixed3);
		}
		set
		{
		}
	}

	public Fixed3 size
	{
		get
		{
			return default(Fixed3);
		}
		set
		{
		}
	}

	public Fixed3 extents
	{
		get
		{
			return default(Fixed3);
		}
		set
		{
		}
	}

	public Fixed3 min
	{
		get
		{
			return default(Fixed3);
		}
		set
		{
		}
	}

	public Fixed3 max
	{
		get
		{
			return default(Fixed3);
		}
		set
		{
		}
	}

	public FixedBounds(Fixed3 center, Fixed3 size)
	{
	}

	public static bool operator ==(FixedBounds lhs, FixedBounds rhs)
	{
		return false;
	}

	public static bool operator !=(FixedBounds lhs, FixedBounds rhs)
	{
		return false;
	}

	public static explicit operator FixedBounds(Bounds src)
	{
		return default(FixedBounds);
	}

	public static explicit operator Bounds(FixedBounds src)
	{
		return default(Bounds);
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public void SetMinMax(Fixed3 min, Fixed3 max)
	{
	}

	public void Encapsulate(Fixed3 point)
	{
	}

	public void Encapsulate(FixedBounds bounds)
	{
	}

	public void Expand(Fixed amount)
	{
	}

	public void Expand(Fixed3 amount)
	{
	}

	public bool Intersects(FixedBounds bounds)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public bool Contains(Fixed3 point)
	{
		return false;
	}

	public Fixed3 GetClosestPoint(Fixed3 point)
	{
		return default(Fixed3);
	}

	public Fixed SqrDistance(Fixed3 point)
	{
		return default(Fixed);
	}

	public void Draw(Color color, float duration = 0f)
	{
	}

	private Fixed ClosestValueSingleAxis(Fixed value, Fixed min, Fixed max)
	{
		return default(Fixed);
	}
}
