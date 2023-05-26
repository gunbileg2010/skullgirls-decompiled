using System;
using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	public class UILineRenderer : MaskableGraphic
	{
		private enum SegmentType
		{
			Start = 0,
			Middle = 1,
			End = 2
		}

		public enum JoinType
		{
			Bevel = 0,
			Miter = 1
		}

		private const float MIN_MITER_JOIN = (float)Math.PI / 12f;

		private const float MIN_BEVEL_NICE_JOIN = (float)Math.PI / 6f;

		private static readonly Vector2 UV_TOP_LEFT;

		private static readonly Vector2 UV_BOTTOM_LEFT;

		private static readonly Vector2 UV_TOP_CENTER;

		private static readonly Vector2 UV_BOTTOM_CENTER;

		private static readonly Vector2 UV_TOP_RIGHT;

		private static readonly Vector2 UV_BOTTOM_RIGHT;

		private static readonly Vector2[] startUvs;

		private static readonly Vector2[] middleUvs;

		private static readonly Vector2[] endUvs;

		[SerializeField]
		private Texture m_Texture;

		[SerializeField]
		private Rect m_UVRect;

		public float LineThickness;

		public bool ignorePivot;

		public bool UseMargins;

		public Vector2 Margin;

		public List<Vector2> Points;

		public bool relativeSize;

		public bool LineList;

		public bool LineCaps;

		public JoinType LineJoins;

		public bool JoinEnds;

		public bool PerformCulling;

		private static Vector2[] tempVerts;

		private static UIVertex[] tempJoint;

		public override Texture mainTexture => null;

		public Texture texture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Rect uvRect
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		public override void Cull(Rect clipRect, bool validRect)
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		private UIVertex[] CreateLineCap(Vector2 start, Vector2 end, SegmentType type)
		{
			return null;
		}

		private UIVertex[] CreateLineSegment(Vector2 start, Vector2 end, SegmentType type)
		{
			return null;
		}

		private void AddJoint(UIVertex[] firstSegment, UIVertex[] secondSegment, VertexHelper vh)
		{
		}

		protected UIVertex[] SetVbo(Vector2[] vertices, Vector2[] uvs)
		{
			return null;
		}
	}
}
