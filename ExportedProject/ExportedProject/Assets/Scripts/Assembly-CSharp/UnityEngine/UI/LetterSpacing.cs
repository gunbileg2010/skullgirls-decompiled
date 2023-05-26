using System.Collections.Generic;

namespace UnityEngine.UI
{
	public class LetterSpacing : BaseMeshEffect, ILayoutElement
	{
		[SerializeField]
		private float m_spacing;

		[SerializeField]
		private bool overrideLayout;

		private Text text;

		public float Spacing
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float minWidth => 0f;

		public float preferredWidth => 0f;

		public float flexibleWidth => 0f;

		public float minHeight => 0f;

		public float preferredHeight => 0f;

		public float flexibleHeight => 0f;

		public int layoutPriority => 0;

		private Text Text => null;

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		public void CalculateLayoutInputHorizontal()
		{
		}

		public void CalculateLayoutInputVertical()
		{
		}

		private void ModifyVerties(List<UIVertex> verts)
		{
		}

		private float CalculateLineOffset(int lineLength, float letterOffset, float alignmentFactor)
		{
			return 0f;
		}

		private int[] GetLineLengths()
		{
			return null;
		}
	}
}
