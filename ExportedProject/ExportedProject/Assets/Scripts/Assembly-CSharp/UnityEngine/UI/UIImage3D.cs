namespace UnityEngine.UI
{
	public class UIImage3D : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter
	{
		[SerializeField]
		private Mesh[] meshes;

		[SerializeField]
		private Texture m_Texture;

		[SerializeField]
		private bool debug;

		public override Texture mainTexture => null;

		public virtual float minWidth => 0f;

		public virtual float preferredWidth => 0f;

		public virtual float flexibleWidth => 0f;

		public virtual float minHeight => 0f;

		public virtual float preferredHeight => 0f;

		public virtual float flexibleHeight => 0f;

		public virtual int layoutPriority => 0;

		protected UIImage3D()
		{
		}

		public virtual void OnBeforeSerialize()
		{
		}

		public virtual void OnAfterDeserialize()
		{
		}

		public void SetMeshes(Mesh[] meshes)
		{
		}

		private Vector4 GetDrawingDimensions(bool shouldPreserveAspect)
		{
			return default(Vector4);
		}

		public override void SetNativeSize()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		public virtual void CalculateLayoutInputVertical()
		{
		}

		public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
		{
			return false;
		}
	}
}
