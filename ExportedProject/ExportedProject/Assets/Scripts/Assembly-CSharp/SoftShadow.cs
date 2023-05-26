using UnityEngine;
using UnityEngine.UI;

public class SoftShadow : Shadow
{
	[SerializeField]
	private float m_BlurSpread;

	[SerializeField]
	private bool m_OnlyInitialCharactersDropShadow;

	public float blurSpread
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool onlyInitialCharactersDropShadow
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected SoftShadow()
	{
	}
}
