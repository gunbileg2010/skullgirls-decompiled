using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ScrollRectController : MonoBehaviour
{
	private AnimatePosition moveToAnim;

	public ScrollRect scrollRect
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private void Awake()
	{
	}

	public void ScrollTo(Transform focusTransform, Vector3 scrollTargetOffset, float duration = 0f)
	{
	}

	public void ScrollTo(Vector3 focusPosition, Vector3 scrollTargetOffset, float duration = 0f)
	{
	}
}
