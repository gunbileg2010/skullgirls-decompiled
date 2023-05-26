using UnityEngine;
using UnityEngine.EventSystems;

namespace Crosstales.UI
{
	public class UIResize : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler
	{
		public Vector2 MinSize;

		public Vector2 MaxSize;

		private RectTransform panelRectTransform;

		private Vector2 originalLocalPointerPosition;

		private Vector2 originalSizeDelta;

		private Vector2 originalSize;

		public void Awake()
		{
		}

		public void OnPointerDown(PointerEventData data)
		{
		}

		public void OnDrag(PointerEventData data)
		{
		}
	}
}
